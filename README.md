# Zip圧縮ツール

.NET4.0から追加されたZip機能の調査ツールの作成のためのツール

## Specification

.NET Console Application (.NET 4.6.2)

**CommandLine**

> ReZipper.exe $SourceDir $DestDir

**Args**
* $SourceDir
  * 圧縮対象のフォルダ


* $DestDir
  * 圧縮ファイルの出力先のフォルダ

## Exsample

ReZipper.exe d:\source d:\dest

* **Input**
  * d:\source\
    * Dir1\
      * File101.jpg
      * File102.jpg
    * Dir2\
      * File201.jpg
      * File202.jpg


* **Output**
  * d:\dest
    * **Dir1.zip\\**
      * File101.jpg
      * File102.jpg
    * **Dir2.zip\\**
      * File201.jpg
      * File202.jpg


> **Note:**
>
> zip compression level is not compressed.