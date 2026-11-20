TEXT ADAPTER — Windows Forms / C# / .NET Framework 4.8
Патерн проєктування: Adapter (Адаптер)

ЩО РОБИТЬ ПРОГРАМА
Програма надає єдиний інтерфейс для роботи з трьома форматами:
- Word (.docx) — справжній файл Office Open XML; текст записується абзацами.
- Excel (.xlsx) — справжній файл Office Open XML; кожен рядок тексту записується в окремий рядок першого аркуша (колонка A).
- TXT (.txt) — звичайний текстовий файл UTF-8.

Усі три адаптери реалізують ITextAdapter:
- ReadText()
- WriteText(text)

Client працює з ITextAdapter і не залежить від конкретного формату.

ЯК ЗАПУСТИТИ
1. Розпакуйте AdapterWinForms.zip у звичайну папку.
2. Встановіть Visual Studio 2019 або 2022 з компонентом ".NET desktop development".
3. Переконайтеся, що встановлено .NET Framework 4.8 Developer Pack / Targeting Pack.
4. Відкрийте AdapterWinForms.sln.
5. У Visual Studio натисніть правою кнопкою на Solution і виберіть Restore NuGet Packages
   (або Build — Visual Studio зазвичай запропонує відновити пакети автоматично).
6. Переконайтеся, що пакет DocumentFormat.OpenXml версії 2.20.0 відновився.
7. Виберіть AdapterWinForms як Startup Project.
8. Натисніть Ctrl+F5 або F5.

ЯК ПЕРЕВІРИТИ
1. Виберіть формат Word (.docx).
2. Введіть кілька рядків у поле "Вміст документа".
3. Натисніть "Зберегти" та задайте ім'я, наприклад test.docx.
4. Очистіть поле, натисніть "Відкрити файл" і виберіть test.docx.
5. Повторіть перевірку для Excel (.xlsx) і TXT (.txt).

СТРУКТУРА ПРОЄКТУ
Adapters/
  ITextAdapter.cs       — цільовий інтерфейс (Target)
  WordAdapter.cs        — адаптер Word
  ExcelAdapter.cs       — адаптер Excel
  PlainTextAdapter.cs   — адаптер TXT
Documents/
  WordDocument.cs       — адаптований клас Word (Adaptee)
  ExcelDocument.cs      — адаптований клас Excel (Adaptee)
  PlainTextFile.cs      — адаптований клас TXT (Adaptee)
Client.cs               — клієнт, що працює через ITextAdapter
MainForm.cs             — логіка Windows Forms
MainForm.Designer.cs    — візуальні компоненти форми
Program.cs              — точка входу

РОЛІ ПАТЕРНА
Client — викликає операції через ITextAdapter.
ITextAdapter — Target, спільний інтерфейс ReadText/WriteText.
WordAdapter, ExcelAdapter, PlainTextAdapter — ConcreteAdapter.
WordDocument, ExcelDocument, PlainTextFile — Adaptee, класи з власними методами.
Adapter перетворює виклики спільного інтерфейсу на виклики методів конкретного класу.

ПРИМІТКА
Для Word та Excel використовується бібліотека DocumentFormat.OpenXml 2.20.0.
Вона створює валідні файли .docx та .xlsx без необхідності встановлювати Microsoft Office.
Для відкриття файлів користувачем Microsoft Office не є обов'язковим для самої програми,
але для перегляду документів можна використовувати Microsoft Word/Excel або сумісний офісний пакет.
