import java.util.Scanner;

public class p02BooleanVariable {

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        String word = scanner.nextLine();

        if (word.equals("True")){
            System.out.println("Yes");
        }
        else if (word.equals("False")) {
            System.out.println("No");

        }
    }
}
