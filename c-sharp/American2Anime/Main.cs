using System; 

public class Program {

  public static void Main(string[] args) {
    Console.Write("Write a japanese sentence in romaji: ");
    string userInput = Console.ReadLine();
    string japchar = "";
    string userOutput = "";
    bool usedQu = false;

    for(int i = 0; i < userInput.Length; i++){
      switch(userInput[i]){
      case 'c':
        switch(userInput[i+1]){
        case 'u':
          japchar="く";
          i++;
          break;
        case 'h':
          switch(userInput[i+2]){
          case 'i':
            japchar="ち";
            i+=2;
            break;
          }
          break;
        default:
          japchar="ｃ";
          break;
        }
        break;
      case 'k':
        switch(userInput[i+1]){
        case 'a':
          japchar="か";
          i++;
          break;
        case 'e':
          japchar="け";
          i++;
          break;
        case 'i':
          japchar="き";
          i++;
          break;
        case 'o':
          japchar="こ";
          i++;
          break;
        case 'u':
          japchar="く";
          i++;
          break;
        case 'y':
          switch(userInput[i+2]){
          case 'a':
            i+=2;
            japchar="きゃ";
            break;
          case 'u':
            i+=2;
            japchar="きゅ";
            break;
          case 'o':
            i+=2;
            japchar="きょ";
            break;
          default:
            japchar="ｙ";
            break;
          }
          break;
        default:
          japchar="ｋ";
          break;
        }
        break;
      case 's':
        switch(userInput[i+1]){
        case 'a':
          japchar="さ";
          i++;
          break;
        case 'e':
          japchar="せ";
          i++;
          break;
        case 'o':
          japchar="そ";
          i++;
          break;
        case 'i':
          japchar="し";
          i++;
          break;
        case 'u':
          japchar="す";
          i++;
          break;
        case 'h':
          switch(userInput[i+2]){
          case 'i':
            japchar="し";
            i+=2;
            break;
          }
          break;
        case 'y':
          switch(userInput[i+2]){
          case 'a':
            i+=2;
            japchar="しゃ";
            break;
          case 'u':
            i+=2;
            japchar="しゅ";
            break;
          case 'o':
            i+=2;
            japchar="しょ";
            break;
          default:
            japchar="ｙ";
            break;
          }
          break;
        default:
          japchar="ｓ";
          break;
        }
        break;
      case 't':
        switch(userInput[i+1]){
        case 'a':
          japchar="た";
          i++;
          break;
        case 'e':
          japchar="て";
          i++;
          break;
        case 'o':
          japchar="と";
          i++;
          break;
        case 's':
          switch(userInput[i+2]){
          case 'u':
            japchar="つ";
            i+=2;
            break;
          }
          break;
        case 'y':
          switch(userInput[i+2]){
          case 'a':
            i+=2;
            japchar="ちゃ";
            break;
          case 'u':
            i+=2;
            japchar="ちゅ";
            break;
          case 'o':
            i+=2;
            japchar="ちょ";
            break;
          default:
            japchar="ｙ";
            break;
          }
          break;
        default:
          japchar="ｔ";
          break;
        }
        break;
      case 'n':
        switch(userInput[i+1]){
        case 'a':
          japchar="な";
          i++;
          break;
        case 'e':
          japchar="ね";
          i++;
          break;
        case 'i':
          japchar="に";
          i++;
          break;
        case 'o':
          japchar="の";
          i++;
          break;
        case 'u':
          japchar="ぬ";
          i++;
          break;
        case 'n':
          japchar="ん";
          i++;
          break;
        case 'y':
          switch(userInput[i+2]){
          case 'a':
            i+=2;
            japchar="にゃ";
            break;
          case 'u':
            i+=2;
            japchar="にゅ";
            break;
          case 'o':
            i+=2;
            japchar="にょ";
            break;
          default:
            japchar="ｙ";
            break;
          }
          break;
        default:
          japchar="ｎ";
          break;
        }
        break;
      case 'f':
        switch(userInput[i+1]){
        case 'u':
          japchar="ふ";
          i++;
          break;
        default:
          japchar="ｆ";
          break;
          }
        break;
      case 'h':
        switch(userInput[i+1]){
        case 'a':
          japchar="は";
          i++;
          break;
        case 'e':
          japchar="へ";
          i++;
          break;
        case 'u':
          japchar="ふ";
          i++;
          break;
        case 'i':
          japchar="ひ";
          i++;
          break;
        case 'o':
          japchar="ほ";
          i++;
          break;
        case 'y':
          switch(userInput[i+2]){
          case 'a':
            i+=2;
            japchar="ひゃ";
            break;
          case 'u':
            i+=2;
            japchar="ひゅ";
            break;
          case 'o':
            i+=2;
            japchar="ひょ";
            break;
          default:
            japchar="ｙ";
            break;
          }
          break;
        default:
          japchar="ｈ";
          break;
        }
        break;
      case 'm':
        switch(userInput[i+1]){
        case 'a':
          japchar="ま";
          i++;
          break;
        case 'e':
          japchar="め";
          i++;
          break;
        case 'i':
          japchar="み";
          i++;
          break;
        case 'o':
          japchar="も";
          i++;
          break;
        case 'u':
          japchar="む";
          i++;
          break;
        case 'y':
          switch(userInput[i+2]){
          case 'a':
            i+=2;
            japchar="みゃ";
            break;
          case 'u':
            i+=2;
            japchar="みゅ";
            break;
          case 'o':
            i+=2;
            japchar="みょ";
            break;
          default:
            japchar="ｙ";
            break;
          }
          break;
        default:
          japchar="ｍ";
          break;
        }
        break;
      case 'y':
        switch(userInput[i+1]){
        case 'a':
          japchar="や";
          i++;
          break;
        case 'o':
          japchar="よ";
          i++;
          break;
        case 'u':
          japchar="ゆ";
          i++;
          break;
        default:
          japchar="ｙ";
          break;
        }
        break;
      case 'l':
        switch(userInput[i+1]){
        case 'a':
          japchar="ら";
          i++;
          break;
        case 'e':
          japchar="れ";
          i++;
          break;
        case 'i':
          japchar="り";
          i++;
          break;
        case 'o':
          japchar="ろ";
          i++;
          break;
        case 'u':
          japchar="る";
          i++;
          break;
        case 'y':
          switch(userInput[i+2]){
          case 'a':
            i+=2;
            japchar="りゃ";
            break;
          case 'u':
            i+=2;
            japchar="りゅ";
            break;
          case 'o':
            i+=2;
            japchar="りょ";
            break;
          default:
            japchar="ｙ";
            break;
          }
          break;
        default:
          japchar="ｒ";
          break;
        }
        break;
      case 'r':
        switch(userInput[i+1]){
        case 'a':
          japchar="ら";
          i++;
          break;
        case 'e':
          japchar="れ";
          i++;
          break;
        case 'i':
          japchar="り";
          i++;
          break;
        case 'o':
          japchar="ろ";
          i++;
          break;
        case 'u':
          japchar="る";
          i++;
          break;
        case 'y':
          switch(userInput[i+2]){
          case 'a':
            i+=2;
            japchar="りゃ";
            break;
          case 'u':
            i+=2;
            japchar="りゅ";
            break;
          case 'o':
            i+=2;
            japchar="りょ";
            break;
          default:
            japchar="ｙ";
            break;
          }
          break;
        default:
          japchar="ｒ";
          break;
        }
        break;
      case 'w':
        switch(userInput[i+1]){
        case 'a':
          japchar="わ";
          i++;
          break;
        case 'e':
          japchar="ゑ";
          i++;
          break;
        case 'i':
          japchar="ゐ";
          i++;
          break;
        case 'o':
          japchar="を";
          i++;
          break;
        default:
          japchar="ｗ";
          break;
        }
        break;
      case 'g':
        switch(userInput[i+1]){
        case 'a':
          japchar="が";
          i++;
          break;
        case 'e':
          japchar="げ";
          i++;
          break;
        case 'i':
          japchar="ぎ";
          i++;
          break;
        case 'o':
          japchar="ご";
          i++;
          break;
        case 'u':
          japchar="ぐ";
          i++;
          break;
        case 'y':
          switch(userInput[i+2]){
          case 'a':
            i+=2;
            japchar="ぎゃ";
            break;
          case 'u':
            i+=2;
            japchar="ぎゅ";
            break;
          case 'o':
            i+=2;
            japchar="ぎょ";
            break;
          default:
            japchar="ｙ";
            break;
          }
          break;
        default:
          japchar="ｇ";
          break;
        }
        break;
      case 'z':
        switch(userInput[i+1]){
        case 'a':
          japchar="ざ";
          i++;
          break;
        case 'e':
          japchar="ぜ";
          i++;
          break;
        case 'i':
          japchar="じ";
          i++;
          break;
        case 'o':
          japchar="ぞ";
          i++;
          break;
        case 'u':
          japchar="ず";
          i++;
          break;
        case 'y':
          switch(userInput[i+2]){
          case 'a':
            i+=2;
            japchar="じゃ";
            break;
          case 'u':
            i+=2;
            japchar="じゅ";
            break;
          case 'o':
            i+=2;
            japchar="じょ";
            break;
          default:
            japchar="ｙ";
            break;
          }
          break;
        default:
          japchar="ｚ";
          break;
        }
        break;
      case 'd':
        switch(userInput[i+1]){
        case 'a':
          japchar="だ";
          i++;
          break;
        case 'e':
          japchar="で";
          i++;
          break;
        case 'i':
          japchar="ぢ";
          i++;
          break;
        case 'o':
          japchar="ど";
          i++;
          break;
        case 'u':
          japchar="づ";
          i++;
          break;
        case 'y':
          switch(userInput[i+2]){
          case 'a':
            i+=2;
            japchar="ぢゃ";
            break;
          case 'u':
            i+=2;
            japchar="ぢゅ";
            break;
          case 'o':
            i+=2;
            japchar="ぢょ";
            break;
          default:
            japchar="ｙ";
            break;
          }
          break;
        default:
          japchar="ｄ";
          break;
        }
        break;
      case 'b':
        switch(userInput[i+1]){
        case 'a':
          japchar="ば";
          i++;
          break;
        case 'e':
          japchar="べ";
          i++;
          break;
        case 'i':
          japchar="び";
          i++;
          break;
        case 'o':
          japchar="ぼ";
          i++;
          break;
        case 'u':
          japchar="ぶ";
          i++;
          break;
        case 'y':
          switch(userInput[i+2]){
          case 'a':
            i+=2;
            japchar="びゃ";
            break;
          case 'u':
            i+=2;
            japchar="びゅ";
            break;
          case 'o':
            i+=2;
            japchar="びょ";
            break;
          default:
            japchar="ｙ";
            break;
          }
          break;
        default:
          japchar="ｂ";
          break;
        }
        break;
      case 'p':
        switch(userInput[i+1]){
        case 'a':
          japchar="ぱ";
          i++;
          break;
        case 'e':
          japchar="ぺ";
          i++;
          break;
        case 'i':
          japchar="ぴ";
          i++;
          break;
        case 'o':
          japchar="ぽ";
          i++;
          break;
        case 'u':
          japchar="ぷ";
          i++;
          break;
        case 'y':
          switch(userInput[i+2]){
          case 'a':
            i+=2;
            japchar="ぴゃ";
            break;
          case 'u':
            i+=2;
            japchar="ぴゅ";
            break;
          case 'o':
            i+=2;
            japchar="ぴょ";
            break;
          default:
            japchar="ｙ";
            break;
          }
          break;
        default:
          japchar="ｚ";
          break;
        }
        break;
      case 'a':
        japchar="あ";
        break;
      case 'i':
        japchar="い";
        break;
      case 'u':
        japchar="う";
        break;
      case 'e':
        japchar="え";
        break;
      case 'o':
        japchar="お";
        break;
      case ' ':
        japchar=" ";
        break;
      case '"':
        if(!usedQu){
          japchar="「";
          usedQu=true;
        }else{
          japchar="」";
          usedQu=false;
        }
        break;
      case '.':
        japchar="。";
        break;
      case ',':
        japchar="，";
        break;
      case '!':
        japchar="！";
        break;
      case '?':
        japchar="？";
        break;
      case '~':
        japchar="〜";
        break;
      }
      userOutput = userOutput+japchar;
    }
    Console.WriteLine(userOutput);
  }
}