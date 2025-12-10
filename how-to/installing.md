# Install Gforth

## Building from Tarball
```bash
wget https://www.complang.tuwien.ac.at/forth/gforth/Snapshots/current/gforth.tar.xz
tar xvfJ gforth.tar.xz
cd gforth-*
./install-deps.sh
./configure
make
sudo make install
```

Official Git Repository
```bash
git clone https://git.savannah.gnu.org/git/gforth/
cd gforth
./install-deps.sh
./autogen.sh
./configure
make
sudo make install
```

## Verify Installation
```bash
gforth --version
```

## Start REPL
```bash
gforth
```
