import java.util.LinkedHashMap;
import java.util.Scanner;

public class p18Phonebook {
    public static void main(String[] args) {

        Scanner scanner = new Scanner(System.in);
        LinkedHashMap<String, String> phonebook = new LinkedHashMap<>();
        String text = scanner.nextLine();

        while (!text.equals("END")){

        String[] array = text.split(" ");
        String command = array[0];
        String name = array[1];


        if (command.equals("A")){
            String number = array[2];

           if (!phonebook.containsKey(name)){
               phonebook.put(name, number);
           }
           phonebook.put(name, number);

        }else if(command.equals("S")){
            if(!phonebook.containsKey(name)){
                System.out.printf("Contact %s does not exist.%n", name);
            }else {

                System.out.println(name+" -> "+ phonebook.get(name));
            }
        }

            text=scanner.nextLine();

        }

    }
}
