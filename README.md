# Lab1_Var1

First Practical Work Asignment, 1 variant from MSU CMC C# homeworks

Language: C#

IDE: VS 2013

This is an accomplished first practical work assignment. Requirements for the task were taken from: Лабораторные работы по курсу Объектно-Ориентированное программирование: язык программирования C# Березина Н.И.  The VS 2013 project includes inplementation of the following simple classes:

## class **Person**
fields
* private field of type `string` to store person's name
* private field of type `string` to strire person's last name
* private field of type `System.DateTime` for birth date

constructors for **Person** class:
* constructor with three parameters of types `string`, `string`, `DateTime`,
  which should initialize all object's fields.
* default constructor, which should initialize all objet's fields with some defaut values.

properties in class **Person** with `get` and `set` methods:
* property of type `string` to access name field
* property of type `string` to access last name field
* property of type `DateTime` to access birth date field
* property of type `int` with both `get` and `set` methods to access private birth date field

methods:
* overridden version of `string ToString()` method, which should return string consisting of all object's fields
* virtual `string ToShortString()` method, which returns a string consisting of name and last name33

## enum Education
{ Specialist, Bachelor, SecondEducation}

## class Exam

has properties:
* of type `string` for Exam name
* of type `int` for Exam grade, received by a particular student
* of type `System.DateTime` for exam date

has constructors:
* with three parameters: `string`, `int`, `DateTime` to initialize Exam properties
* default constructor with no parameters, which assigns default values to Exam properties

has methods:
* overriden `string ToString()` method with returns a string representation of all method fields

## class Student

has fields:
* private field of type Person to store basic data about a student
* private field of type Education to store education degree
* private field of type int to store group number
* private field of type Exam[] to store a list of student's exam

has constructors:
* with parameters of types `Person`, `Education`, `int`, to initialize those fields
* default constructor

## Workload

Compare execution time of some simple operation performed on each object for one-dimensional, two-dimensional and jagged arrays of those objects.
