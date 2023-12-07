# Задача 

Написать программу, которая из имеющегося массива строк формирует новый массив 
из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести 
с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется 
пользоваться коллекциями, лучше обойтись исключительно массивами.

Примеры:
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → []

# Решение

#### 1. Создать массив строк sourseArray[]

#### 2. Создать переменную newArrayLength, вызвать метод NewArrayLength.

    Метод NewArrayLength:

        Входные параметры:
            - array: массив строк, для которого нужно определить количество строк с длиной не более 3 символов.

        Выходные данные:
            - count: количество строк в массиве array, удовлетворяющих условию длины <= 3.

        Описание:
        Метод проходит по каждой строке в массиве array и проверяет её длину. Если длина строки не превышает 3 символа, увеличивает значение count на 1.
        В конце возвращает значение count.

#### 3. Создать новый массив newArray, вызвать метод GetNewArray.
Метод GetNewArray:

    Входные параметры:
        - array: исходный массив строк;
        - length: количество строк, которые следует сохранить в новом массиве.

    Выходные данные:
        - newArray: новый массив строк, содержащий строки с длиной <= 3 символов из исходного массива.

    Описание:
        Метод создает новый массив newArray заданной длины. Затем проходит по каждой строке в исходном массиве array.
        Если длина строки не превышает 3 символа, добавляет её в новый массив newArray.
        Возвращает новый массив newArray.

#### 4. Вызвать метод PrintArray.
Метод PrintArray:

    Входные параметры:
        - array1: массив строк
        - array2: массив строк

    Описание:
        Метод выводит содержимое массива array1 и массива array2 на консоль.