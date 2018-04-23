import java.util.Scanner;

public class p01VariableInHexadecimalFormat {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        String word = scanner.nextLine();

        System.out.println(Integer.parseInt(word,16));
    }
}
