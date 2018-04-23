import java.util.Arrays;
import java.util.List;
import java.util.Scanner;
import java.util.stream.Collectors;

public class p12BombNumbers {
    public static void main(String[] args) {

        Scanner scanner = new Scanner(System.in);

        List<Integer> numbers = Arrays
                .stream(scanner.nextLine().split(" "))
                .map(Integer::parseInt)
                .collect(Collectors.toList());

        int [] infoTokens = Arrays.stream(scanner.nextLine()
                .split(" "))
                .mapToInt(Integer::parseInt)
                .toArray();

        int specialNumber = infoTokens[0];
        int range = infoTokens[1];

        while (numbers.contains(specialNumber)){

            int index = numbers.indexOf(specialNumber);

            int leftIndex = (index - range) < 0 ? 0 : index - range;


            int rightIndex = (index + range) >= numbers.size() ? numbers.size()-1 : index + range;


            numbers.subList(leftIndex, rightIndex +1).clear();


        }
        int sum = numbers.stream().mapToInt(Integer::intValue).sum();

        System.out.println(sum);


    }
}
