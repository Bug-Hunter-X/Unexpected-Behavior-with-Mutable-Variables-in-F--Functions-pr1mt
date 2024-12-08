# Unexpected Behavior with Mutable Variables in F# Functions

This example demonstrates a common pitfall in F#: unexpected behavior when using mutable variables within functions.  Specifically, it shows how modifying a mutable variable inside a function can affect the values of other variables unexpectedly.

## Bug Description
The core issue is that the function `addOne2` modifies the input variable `a` directly. This change is reflected outside the function's scope, resulting in different results when the function is called multiple times, compared to the function `addOne`, which does not modify the input variable directly.

## Solution
The solution involves avoiding the direct modification of the input variable within the function.  A copy of the value can be used instead, preserving the initial value of the variable outside the function's scope.
