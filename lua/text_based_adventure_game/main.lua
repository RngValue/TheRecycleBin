require "textventure"

draw_dialog("game", "hello", 0.025)
draw_dialog("game", "helloaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa", 0.025)
draw_dialog("game", "helloaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa", 0.025)
draw_choice("game", "how are you?", "good", "happy", "fuck you", 1, 3, 0.025)
if userInput == "1" then
    draw_dialog("game", "yay", 0.025)
elseif userInput == "2" then
    draw_dialog("game", "ha", 0.025)
else
    draw_dialog("game", "ok", 0.025)
end
userInput = ""