import java.util.Scanner;

public class p04VowelOrDigit {

    public static void main(String[] args) {

        Scanner scanner = new Scanner(System.in);

        String symbol = scanner.nextLine();

        if (symbol.matches("\\d+")) {
            System.out.println("digit");

        } else if (symbol.equals("a")
                || symbol.equals("o")
                || symbol.equals("u")
                || symbol.equals("e")
                || symbol.equals("i")) {

            System.out.println("vowel");
        }else{
            System.out.println("other");
        }
    }
}
