# Stack

Простая библиотека, чтобы исследовать баг, когда скомпилированный проект под Ubuntu 22.04 не хочет запускаться под Win7.

## Воспроизведение

В [./.github/workflows/build.yml](./.github/workflows/build.yml) описаны нюансы сборки библиотеки.

* Скачать `artifact.zip`
  * Перейти в **Actions**
  * Выбрать последний workflow
  * Выбрать **Summary**
  * Промотать вниз и нажать на **artifact**

* Распаковать в папку

* Создать `Program.fsx`:

  ```fs
  #!dotnet fsi
  #r @"Stack.dll"
  open StackLibrary

  Stack.empty |> Stack.push 1 |> printfn "%A"
  ```

* Запустить скрипт:

  ```
  dotnet fsi Program.fsx
  ```

Выбивает:

> Program.fsx(3,6): error FS0039: The namespace or module 'StackLibrary' is not defined.

При этом если собрать библиотеку под Win7, то всё отлично работает. Скомпилированную библиотеку можно найти в [./compiled-win7/](./compiled-win7/).
