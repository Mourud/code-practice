import java.util.Scanner;

public class bcalculator {
    public static void main(String[] args) {
        int num1 = 0, num2 = 0;
        System.out.println("Enter a number: ");
        try (Scanner scanner = new Scanner(System.in)) {
            num1 = scanner.nextInt();
            System.out.println("Enter another number: ");
            num2 = scanner .nextInt();
        }
        System.out.println(num1 + " + " + num2 + " = " + (num1 + num2));
        System.out.println(num1 + " - " + num2 + " = " + (num1 - num2));
        System.out.println(num1 + " * " + num2 + " = " + (num1 * num2));
        System.out.println(num1 + " / " + num2 + " = " + ((double) num1 / num2));

    }
}