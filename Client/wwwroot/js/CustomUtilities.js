function my_function(message) {
    console.log("From CustomUtilities: " + message);
}

function  dotnetStaticInvocation() {
    // First param: Package; Second param: Static Method
    DotNet.invokeMethodAsync("BlazorMovies.Client", "GetCurrentCount")
        .then(result => {           // Return a Promise
            console.log("Retrieve count from C#: " + result);
        });
}

function dotnetInstanceInvocation(dotnetHelper) {
    dotnetHelper.invokeMethodAsync("IncrementCount")
        .then(() => console.log("dotnetInstanceInvocation Called..."));  // Note! Returns a Promise which could have a return Value of desired
}

