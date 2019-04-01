Protocol Buffers 
================

Generate C# classes from dex.proto

Download protoc compiler

```
https://github.com/protocolbuffers/protobuf/releases/tag/v3.7.1
```


Run the protoc compiler

```
protoc -I=$SRC_DIR --csharp_out=$DST_DIR $SRC_DIR/addressbook.proto
```

For example run protoc from PowerShell and generates dex.cs
```
C:\protoc-3.7.1-win64\bin\protoc.exe .\dex.proto --csharp_out=.
```