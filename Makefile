all: dotnet_build rust_build run

dotnet_build:
	dotnet build --output out cs-interop/cs-interop.csproj

rust_build:
	cd rust-interop/; cargo b --lib 
	rm -rf ./out/librust_interop.so
	mv rust-interop/./target/debug/librust_interop.so ./out

run:
	@echo "+------------------+"
	@echo "|Runing the project|"
	@echo "+------------------+"
	out/cs-interop
