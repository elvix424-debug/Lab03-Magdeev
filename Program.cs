// Console.WriteLine("Банковский счёт");

// double balance = 1000;
// Console.WriteLine($"Начальный баланс: {balance}");

// balance += 500; // пополнение
// Console.WriteLine($"После пополнения на 500: {balance}");

// balance -= 200; // покупка
// Console.WriteLine($"После покупки на 200: {balance}");

// balance *= 1.05; // начисление 5% процентов
// Console.WriteLine($"После начисления 5%: {balance}");

// balance /= 2; // разделили счёт пополам с партнёром
// Console.WriteLine($"После деления пополам: {balance}");


// Console.WriteLine();
// Console.WriteLine("Постфикс vs префикс");

// int lessonNumber = 1;
// Console.WriteLine($"lessonNumber++  выводит: {lessonNumber++}");
// Console.WriteLine($"После этого lessonNumber = {lessonNumber}");

// int weekNumber = 1;
// Console.WriteLine($"++weekNumber  выводит: {++weekNumber}");
// Console.WriteLine($"После этого weekNumber = {weekNumber}");

// Console.WriteLine();
// Console.WriteLine("Практическая ловушка");

// int attempts = 0;
// Console.WriteLine($"Попытка №{++attempts}");
// Console.WriteLine($"Попытка №{++attempts}");
// Console.WriteLine($"Всего попыток: {attempts}");


// Console.WriteLine();
// Console.WriteLine("Операторы сравнения");

// double myGrade = 4.6;
// double passingGrade = 4.0;
// int myAge = 20;
// int votingAge = 18;
// bool isPassing = myGrade >= passingGrade;
// bool isExactAge = myAge == votingAge;
// bool canVote = myAge >= votingAge;
// bool isNotFailing = myGrade != 2.0;

// Console.WriteLine($"Балл {myGrade} >= {passingGrade}: {isPassing}");
// Console.WriteLine($"Возраст {myAge} == {votingAge}: {isExactAge}");
// Console.WriteLine($"Возраст {myAge} >= {votingAge} (может голосовать): {canVote}");
// Console.WriteLine($"Балл {myGrade} != 2.0 (не двойка): {isNotFailing}");


// Console.WriteLine();
// Console.WriteLine("Логические операторы");

// bool hasPassingGrade = true;
// bool hasAttendance = false;
// bool hasDebt = true;

// bool canGetScholarship = hasPassingGrade && hasAttendance;
// bool canRetakeExam = hasPassingGrade || hasAttendance;
// bool isDebtFree = !hasDebt;

// Console.WriteLine($"Может получить стипендию (оценка И посещаемость): {canGetScholarship}");
// Console.WriteLine($"Может пересдать (оценка ИЛИ посещаемость): {canRetakeExam}");
// Console.WriteLine($"Нет долгов: {isDebtFree}");


// Console.WriteLine();
// Console.WriteLine("Короткое замыкание");

// bool CheckAndPrint(string label, bool value)
// {
//     Console.WriteLine($"  Вычисляется: {label}");
//     return value;
// }

// Console.WriteLine("Проверяем && (первый операнд false):");
// bool resultAnd = CheckAndPrint("A", false) && CheckAndPrint("B", true);
// Console.WriteLine($"Результат: {resultAnd}");

// Console.WriteLine();
// Console.WriteLine("Проверяем || (первый операнд true):");
// bool resultOr = CheckAndPrint("C", true) || CheckAndPrint("D", false);
// Console.WriteLine($"Результат: {resultOr}");

// Console.WriteLine();
// Console.WriteLine("Приоритет операций");

// int resultNoParens = 2 + 3 * 4;
// int resultWithParens = (2 + 3) * 4;
// Console.WriteLine($"2 + 3 * 4       = {resultNoParens}");
// Console.WriteLine($"(2 + 3) * 4     = {resultWithParens}");
// bool logicResult = 5 > 3 && 2 < 4 || false;
// bool logicResultParens = (5 > 3 && 2 < 4) || false;
// Console.WriteLine($"5>3 && 2<4 || false    = {logicResult}");
// Console.WriteLine($"(5>3 && 2<4) || false  = {logicResultParens}");


// Console.WriteLine();
// Console.WriteLine("Приёмная комиссия");

// Console.Write("Введите средний балл аттестата: ");
// double averageGrade = double.Parse(Console.ReadLine());

// Console.Write("Введите баллы за экзамен (0-100): ");
// int examScore = int.Parse(Console.ReadLine());

// Console.Write("Есть льгота? (1 - да, 0 - нет): ");
// int benefitInput = int.Parse(Console.ReadLine());
// bool hasBenefit = (benefitInput == 1);

// // TODO 1
// bool hasGoodCertificate = averageGrade >= 4.0;
// // TODO 2
// bool hasGoodExam = examScore >= 60;
// // TODO 3
// bool isEligibleByRules = (hasGoodCertificate && hasGoodExam) || hasBenefit;

// // TODO 4
// double totalScore = averageGrade * 10;
// totalScore += examScore;

// Console.WriteLine();
// Console.WriteLine("Результат");
// Console.WriteLine($"Хороший аттестат (>= 4.0): {hasGoodCertificate}");
// Console.WriteLine($"Хороший экзамен (>= 60): {hasGoodExam}");
// Console.WriteLine($"Льгота: {hasBenefit}");
// Console.WriteLine($"Проходит по правилам: {isEligibleByRules}");
// Console.WriteLine($"Итоговый балл: {totalScore}");

//Задание 1. Чётное или нечётное—без if ★
// Console.WriteLine();
// Console.Write("Введите целое число: ");
// int number = int.Parse(Console.ReadLine());

// bool isEven = number % 2 == 0;
// Console.WriteLine($"Число {number} чётное: {isEven}");


//Задание 2. Инкремент в выражении ★★
// Console.WriteLine();

// // 1 место просто вывод
// int coins = 10;
// Console.WriteLine($"coins++ выводит: {coins++}"); // выведет 10, потому что сначала берётся старое значение, а потом уже прибавляется 1
// Console.WriteLine($"++coins выводит: {++coins}"); // выведет 12, потому что coins уже был 11 и сначала прибавляется 1, а потом выводится

// // 2 место в математике
// int level = 5;
// int bonus1 = level++ * 2; // 5 * 2 = 10, умножается старое значение, а level потом стал 6
// int bonus2 = ++level * 2; // level сначала стал 7, потом 7 * 2 = 14
// Console.WriteLine($"bonus1 = {bonus1}, bonus2 = {bonus2}, level = {level}");

// // 3 место при присваивании в другую переменную
// int steps = 0;
// int a = steps++; // в a попадает 0, потому что сначала присваивается, а потом steps становится 1
// int b = ++steps; // steps сначала становится 2, и в b попадает уже 2
// Console.WriteLine($"a = {a}, b = {b}, steps = {steps}");

//Задание 3. Калькулятор скидки несколькими условиями★★★
Console.WriteLine();
Console.Write("Введите сумму покупки: ");
double purchaseSum = double.Parse(Console.ReadLine());

Console.Write("Есть карта постоянного клиента? (1 - да, 0 - нет): ");
int cardInput = int.Parse(Console.ReadLine());
bool hasCard = (cardInput == 1);

Console.Write("Введите количество товаров в чеке: ");
int itemsCount = int.Parse(Console.ReadLine());

bool isBigSum = purchaseSum >= 3000;
bool isManyItems = itemsCount >= 3;
bool eligibleForDiscount = (isBigSum && isManyItems) || hasCard;

Console.WriteLine($"Сумма >= 3000: {isBigSum}");
Console.WriteLine($"Товаров >= 3: {isManyItems}");
Console.WriteLine($"Есть карта: {hasCard}");
Console.WriteLine($"Положена скидка: {eligibleForDiscount}");