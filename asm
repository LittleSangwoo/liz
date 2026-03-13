#include <iostream>
#include <locale>

using namespace std;

int main() {
    setlocale(LC_ALL, "Russian");

    unsigned short inputNumber;
    unsigned short totalUnits = 0;
    unsigned short units1_4 = 0;

    cout << "Введите число (0-65535): ";
    cin >> inputNumber;

    [span_0](start_span)// --- 1. Подсчет всех единиц в числе ---[span_0](end_span)
    __asm {
        mov ax, inputNumber // Загружаем число в AX
        xor cx, cx          // Обнуляем счетчик единиц (CX)
        mov bx, 16          // Всего 16 бит в AX

    total_loop:
        [span_1](start_span)shl ax, 1           // Сначала сдвигаем влево[span_1](end_span)
        [span_2](start_span)jc mo1              // Если бит ушел в CF, прыгаем на инкремент[span_2](end_span)
        jmp skip_total      // Иначе пропускаем

    mo1:
        [span_3](start_span)inc cx              // Увеличиваем счетчик[span_3](end_span)

    skip_total:
        dec bx              // Уменьшаем счетчик цикла
        jnz total_loop      // Если bx != 0, повторяем

        mov totalUnits, cx  // Возвращаем результат в переменную C++
    }

    [span_4](start_span)// --- 2. Подсчет единиц в битах 1-4 ---[span_4](end_span)
    // Чтобы биты 1,2,3,4 попадали в CF, нужно сдвинуть AX так, 
    // чтобы 4-й бит стал 15-м (сдвиг на 11 влево)
    __asm {
        mov ax, inputNumber
        shl ax, 11          // 15 - 4 (позиция конца диапазона) = 11
        xor cx, cx
        mov bx, 4           // Длина диапазона (1-4 это 4 бита)

    range_loop:
        shl ax, 1           // Сдвигаем
        jc mo_range
        jmp skip_range
    mo_range:
        inc cx              // Считаем
    skip_range:
        dec bx
        jnz range_loop

        mov units1_4, cx    // Сохраняем результат для 1-4
    }

    // Вывод результатов средствами C++
    cout << "Всего единиц в числе: " << totalUnits << endl;
    cout << "Единиц в битах 1-4: " << units1_4 << endl;

    return 0;
}
