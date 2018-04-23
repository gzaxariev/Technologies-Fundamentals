import java.util.Scanner;

public class p13ReverseString {
    public static void main(String[] args) {

        Scanner scanner = new Scanner(System.in);

        String word = scanner.nextLine();

        String reverse = new StringBuilder(word).reverse().toString();
        System.out.println(reverse);

    }
}
