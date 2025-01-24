using System;
using AttributeSample.Domain;
Person _person = new Person();

// به دو روش زیر می تونیم به هر اطلاعاتی از تایپمون دسترسی داشته باشیم.
Type personType01 = _person.GetType();
// خود 
// Type
// به صورت پیش فرض 
// abstract
// هست و نمیشه ازش اینستنس ساخت
Console.WriteLine(personType01.FullName);
Console.WriteLine(personType01.AssemblyQualifiedName);
// Person
// Person, AttributeSample.Domain, Version = 1.0.0.0, Culture = neutral, PublicKeyToken = null
Type personType02 = typeof(Person);
Console.WriteLine(personType02.FullName);
// Person

// در روش زیر باید نام کامل تایپمون رو داخل یک رشته بنویسیم و بعد 
// یک مقدار بولی 
// true & false
// براش تعریف کنیم. وقتی 
// true
// می نویسیم اگر نتونه تایپی که نوشتیم رو پیدا کنه اکسپشن میده و اگر
// false
// بنویسیم نال برمی گردونه 
Type personType03 = Type.GetType("AttributeSamples.ReflectionUI.Teacher", true, true);
Console.WriteLine(personType03.FullName);
// AttributeSamples.ReflectionUI.Teacher

// اگر تایپمون توی یک اسمبلی دیگه بود باید اسم اسمبلی اش رو هم بنویسیم وگرنه پیداش نمیکنه
Type personType04 = Type.GetType("AttributeSample.Domain.Person, AttributeSample.Domain", true, true);
Console.WriteLine(personType04.FullName);
