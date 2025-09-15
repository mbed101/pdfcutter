import os
import subprocess
import shutil
import sys

# Config
PROJECT_PATH = os.path.abspath("pdfcutter.Desktop")  # Change this
OUTPUT_DIR = os.path.join(PROJECT_PATH, "publish")
APP_NAME = "pdfcutter.Desktop"
VERSION = "1.0.0"

# Runtime identifiers
RID_LINUX = "linux-x64"
RID_WINDOWS = "win-x64"

# Ensure publish directory exists
os.makedirs(OUTPUT_DIR, exist_ok=True)
DOTNET = "/home/lex/.dotnet/dotnet"
# Step 1: Build the Avalonia project for Linux and Windows
def dotnet_publish(runtime):
    print(f"Publishing for {runtime}...")
    subprocess.check_call([
        DOTNET, "publish", PROJECT_PATH,
        "-c", "Release",
        "-r", runtime,
        "--self-contained", "true",
        "/p:PublishSingleFile=true",
        "/p:PublishTrimmed=true",
        "-o", os.path.join(OUTPUT_DIR, runtime)
    ])

dotnet_publish(RID_LINUX)
dotnet_publish(RID_WINDOWS)

# Step 2: Create Debian package
def create_deb():
    deb_dir = os.path.join(OUTPUT_DIR, "deb_package")
    os.makedirs(deb_dir, exist_ok=True)

    # Debian structure
    usr_bin = os.path.join(deb_dir, "usr", "bin")
    os.makedirs(usr_bin, exist_ok=True)

    # Copy Linux executable
    shutil.copy(os.path.join(OUTPUT_DIR, RID_LINUX, APP_NAME), usr_bin)

    # Control file
    control = f"""Package: {APP_NAME.lower()}
Version: {VERSION}
Section: utils
Priority: optional
Architecture: amd64
Maintainer: Your Name <you@example.com>
Description: {APP_NAME} Avalonia App
"""
    control_dir = os.path.join(deb_dir, "DEBIAN")
    os.makedirs(control_dir, exist_ok=True)
    with open(os.path.join(control_dir, "control"), "w") as f:
        f.write(control)

    # Build .deb
    deb_file = os.path.join(OUTPUT_DIR, f"{APP_NAME}_{VERSION}_amd64.deb")
    subprocess.check_call(["dpkg-deb", "--build", deb_dir, deb_file])
    print(f"Deb package created: {deb_file}")

create_deb()

print("Packaging complete!")
