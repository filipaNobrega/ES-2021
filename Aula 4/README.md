# Padrões de Desenho

## THE SIMPLE FACTORY PATTERN

_Encapsulates object creation in one place. Should be the only part of the application that refers to concrete classes._

_Reduces duplicate code by enforcing **DRY** (Don't Repeat Yourself)._

_Static versus Singleton: For a simple factory static is good enough because we're not maintaining state, we're encapsutating the creation of a new object._

## THE TEMPLATE METHOD PATTERN

_Define the skeleton of an algorithm in an operation, deferring some steps to subclasses. It lets one redefine one or more steps of an algorithm without changing the algorithm's structure (Liskov principle)._

## THE FACTORY METHOD PATTERN

_Define an interface for creating an object, but let subclasses decide which class to instantiate. It lets a class defer instantiation to subclasses._

## THE SINGLETON PATTERN

_Ensure a class only has one instance, and provide global access to that instance._

_Commonly use to implement many other patterns: factories (abstract and simple), façade, state, builder, and prototype._

_Many DI frameworks provide singleton support._

## THE ABSTRACT FACTORY PATTERN

_Provide an interface for creating families of related or dependent objects without specifying their concrete classes._