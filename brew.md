## 🍺 Homebrew Essential Commands

### 🚀 Installation Command

This is the main command to install Homebrew itself.

```bash
/bin/bash -c "$(curl -fsSL [https://raw.githubusercontent.com/Homebrew/install/HEAD/install.sh](https://raw.githubusercontent.com/Homebrew/install/HEAD/install.sh))"
```
####  Install a Package
Installs a formula (package) like wget or python.

```bash
brew install <package_name>
```
####  Update Homebrew
Fetches the latest updates for Homebrew itself and all installed formulae/casks.

```bash
brew update
```

####  Upgrade Installed Packages
Upgrades all outdated installed packages.

```bash
brew upgrade
```

####  Search for a Package
Searches for available formulae and casks (macOS apps) matching a given name.

```bash
brew search <package_name>
```

####  View Info about a Package
Displays detailed information about a specific installed or available package.

```bash
brew info <package_name>
```

####  List Installed Packages
Lists all packages that are currently installed via Homebrew.

```bash
brew list
```

####  Uninstall a Package
Removes an installed package and its associated files.

```bash
brew uninstall <package_name>
```

####  Check for Problems
Runs a self-diagnostic to identify and report potential issues with your Homebrew installation.

```bash
brew doctor
```

####  Clean Up Cached Downloads
Removes stale lock files and old downloads for all formulae and casks, freeing up disk space.

```bash
brew cleanup
```

####  Check for Outdated Packages
Lists all installed formulae and casks that have newer versions available.

```bash
brew outdated
```