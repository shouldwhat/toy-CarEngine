# dotnet-carEngine

* **Instroduce Proejct**
```
	*. this project explain car-moving-engine.
```

---

* **Instructions**
```
    (1). execute application.

    (2). if left click in canvas panel, car is going to move.
```

---

* **Using**
```
    (1). using .NET Framework

    (2). using 'singleton pattern', 'observer pattern'

    (3). using 'delegate', 'event' keyword
```

---

* **Class diagram**

![](/images/class.png)

---

* **Class**
```
	(1). Car : Main Model Object (Model)
	
	(2). CarNavigator : calcurate Head Direction. (Attribute Object of Car)
	
	(3). CarHandle : calcurate Handle Angle. (Attribute Object of Car)
	
	(4). CarEngine : calcurate Next Moving Point. (Attribute Object of Car)
	
	(5). MyMathUtil : calcurate trigonometric function.
	
	(6). ReDrawingCarManager : repaint car image. (Event)
	
	(7). MovingFinishedManager :  finish moving car. (Event)
```	
	
---

* **Sequence diagram**

	*. **Car Moving(=drive())**
	![](/images/sequence_drive.png)

---
