using Lab1;

Person person1 = new()
{ PhoneNumber = 89829994050 };
Person person2 = new("Ivan", "Ivanov", 20);

person1.WhatIsPhoneNumber();
person2.WhatIsPhoneNumber();