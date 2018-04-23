import java.util.Scanner;

public class p05IntegerToHexAndBinary {
    public static void main(String[] args) {

        Scanner scanner = new Scanner(System.in);

        int decimalNumber =Integer.parseInt(scanner.nextLine());

        System.out.println(Integer.toHexString(decimalNumber).toUpperCase());
        System.out.println(Integer.toBinaryString(decimalNumber));


    }
}
