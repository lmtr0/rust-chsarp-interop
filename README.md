# rust-chsarp-interop
Example of Interop between c# and rust

# Idea
Test how to make a c-compatible interop library in rust for use in all languadges that have the capability of calling C libraries (most all).

I Test it using c# because I like the lang and it has some problems with type marshing

## What the library Covers

I made A simple clone of printf renamed it to printc, it takes a valid c string and converts is to a rust string or &str and then print it to the console

I also made a function that takes a function pointer, calls the function and returns a function pointer.

Since we can turn structs in rust to a c struct and the same on c#, I didn't make an example but [this article](https://dev.to/living_syn/calling-rust-from-c-6hk) covers how to do it.

# How to Build and run

the project is made so that you only need one command to build it, it's litterly just 

```Shell
make
```

If you look into `Makefile` you would see that the `make` command will first build the c# project, then build the rust project, output everything to the out directory and run it.

If you wish you can run the commands individually, but i don't understand why you would do it.

Have fun!!

# License
This project is under the MIT License and you are free to use it as you please, just don't forget the copyright notice.

