# Zip���k�c�[��

.NET4.0����ǉ����ꂽZip�@�\�̒����c�[���̍쐬�̂��߂̃c�[��

## Specification

.NET Console Application (.NET 4.6.2)

**CommandLine**

> ReZipper.exe $SourceDir $DestDir

**Args**
* $SourceDir
  * ���k�Ώۂ̃t�H���_


* $DestDir
  * ���k�t�@�C���̏o�͐�̃t�H���_

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