# Facade

* _Описание:_
      Facade скрива сложната функционалност и дава по-лесен интерфейс.
      
* _Връзки с други patterns:_
      Facade е близък до Adapter по замисъл. Разликата е, че Facade създава нов
      интерфейс, с който обединява сложни операции в една. Adapter прехвърля функционалностот един клас,
      който не може директно да се ползва, на друг.
      Flyweight също има общи черти. Докато той показва как да се създадат много и малки обекти, Facade показва как да
      създадем един обект, който да представлява цяла подсистема.

* _Приложение:_
      Когато клиент иска опростен интерфейс на дадена функционалност, част от сложна подсистема.
      
* _Имплементация:_
      Предоставеният пример използва анимационния герой Инспектор Гаджет, за да демонстрира идеята на Facade.

![inspector-gadget](../images/inspector-gadget.jpg)
