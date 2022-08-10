# Software 1 - Class Exercise 5
## Goals
- Add interfaces
- Use linq queries

## Instructions
### Interfaces
Interfaces are critical to modern programming.  There are multiple concepts and programming patterns that rely on interfaces.  While we aren't going to explore any of those in this course, we are going to learn how to use interfaces.
1. We have an existing class that would be great to have an interface for: `ProductLogic`.
1. Create a new _Interface_ and call it `IProductLogic`.  You do it the same way you do a class, you just select Interface isntead of Class.  If you create a class by accident, you can just change the keyword `class` to `interface`.
1. In this interface, we're going to be saying _what_ functions need to be implemented, not _how_ they are.
1. So look at the `ProductLogic` class and add the already existing methods to the interface.  Here's the first one: `public void AddProduct(Product product);`
1. Once all the existing methods have been added to the interface, head over to the `ProductLogic` class again and let's have the class _implement_ the interface.  You do this using the same syntax you use to have a class _inherit_ from another `:`.
1. Once we have `ProductLogic implementing `IProductLogic`, let's add a new method to our interface.
1. Add a method called `GetOnlyInStockProducts`.  It doesn't need to take any arguments and it will return `List<Product>`.
1. Heading back to `ProductLogic` you should see a build error.  This is because our `ProductLogic` class isn't fully implementing the interface.  We'll be doing that in the next section.

### Using Linq
1. In the `ProductLogic` class, in the constructor where you are creating a new list of products, instead of having that list be empty, go ahead and add 2 or 3 products to it.  One of those products should have a quantity of 0.
1. Add the method from the interface that hasn't yet been implemented.
1. In that method body, we are going to filter our product list to only return products with quantity greater than 0.
1. To normally do this, we would probably use a `for` loop to iterate through the whole list checking each one to see if its quantity is greater than 0.  If it is, we would add it to a new list then return that list.  We're going to use linq for this though which will greatly simplify our method.
1. In the method body, type of this: `return _products.Where(x => x.Quantity > 0).ToList();`
1. Let's take this a step further.  Let's say we would only want to return the names of the products.  We would do this by using the `Select` method.  This one would sit between `Where` and `ToList`. Go ahead and add `.Select(x=>x.Name)`.  You will have build errors from this, so go ahead and fix that.  You'll need to make changes in `ProductLogic` and `IProductLogic`.
1. Finally, add a UI option to view in stock products only.