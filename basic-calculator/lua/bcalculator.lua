
function bcalculator()
    print("Enter an integer")
    local num1 = io.read("*n")
    print("Enter another integer")
    local num2 = io.read("*n")
    print(num1 .. " + " .. num2 .. " = " .. num1 + num2)
    print(num1 .. " - " .. num2 .. " = " .. num1 - num2)
    print(num1 .. " * " .. num2 .. " = " .. num1 * num2)
    print(num1 .. " / " .. num2 .. " = " .. num1 / num2)
end

bcalculator()