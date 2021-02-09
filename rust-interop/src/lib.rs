extern crate libc;
// use cstr::cstr;
use std::ffi::CStr;
use std::ffi;
use libc::*;

pub extern fn greeting(){
    println!("Hello Wolrd! rust speaking.");
}

#[no_mangle]
pub extern "C" fn printc(c_buf: *const c_char){
    let c_str: &CStr = unsafe { CStr::from_ptr(c_buf) };
    let str_slice: &str = c_str.to_str().unwrap();
    //let str_buf: String = str_slice.to_owned();  // if necessary
    println!("c# string is is {}", str_slice);
}

#[no_mangle]
pub extern "C" fn takeFunctionPointerAndCallIt(function_pointer: extern fn() -> ()) -> extern fn() {
    function_pointer();
    return greeting;
}