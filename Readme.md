Dependencies:   sharpcompress\0.32.2\  and  sevenzipsharp.net45\1.0.19\

Coded for doing dictionary attack to 

* Aspose: rar, rar5        
* SevenZipSharp: 7z, Zip, GZip, BZip2, Tar, Xz ...
archive files.

Dictionary file is supposed to be txt file that 
consist of passwords line by line.

Program needs 7z.dll file where it can be found default installtion location of 7-zip. I tested with 22.01 version.

If password is found, it will printed over 'Result:' label. 

After password is found, decompress the file manually with the found pass. Auto decompression gives bad output i dont know why.
