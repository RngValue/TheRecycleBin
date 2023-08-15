width = 41

function sleep(n)
    local t = os.clock()
    while os.clock() - t <= n do
      -- nothing
    end
end

items = {}
function show_items()
    io.write("#################<Items>#################\n")
    io.write("#\t", type(items[1]), "\t", type(items[2]), "\t", type(items[3]), "\t", type(items[4]), "\t#\n")
    io.write("#########################################\n")
end

function draw_dialog(charName, text, delay)
    os.execute("clear")
    show_items()
    io.write("\n")
    io.write(charName, ":\n")
    for i = 1, #text do
        if i == width+1 or i == width*2+1 then io.write("\n") end
        io.write(string.sub(text, i, i))
        sleep(delay)
        if i == width*3 - 3 then break end
    end
    if #text <= width then
        io.write("\n")
        io.write("\n")
        for j = 1, width - 2 do io.write(" ") end
        io.write("<>")
    elseif #text <= width*2 then
        io.write("\n")
        for j = 1, width - 2 do io.write(" ") end
        io.write("<>")
    else
        for j = 1, width - (#text - width*2) - 2 do io.write(" ") end
        io.write("<>")
    end
    io.read()
end

userInput = ""
function draw_choice(charName, text, choiceOne, choiceTwo, choiceThree, choices, delay)
    os.execute("clear")
    show_items()
    io.write("\n")
    io.write(charName, ":\n")
    for i = 1, #text do
        io.write(string.sub(text, i, i))
        sleep(delay)
        if i == width then break end
    end
    io.write("\n")
    for i = 1, choices do
        io.write(i, ". ")
        if i == 1 then io.write(choiceOne, "; ") end
        if i == 2 then io.write(choiceTwo, "; ") end
        if i == 3 then io.write(choiceThree, "; ") end
    end
    io.write("\n")
    io.write(">")
    userInput = io.read("*l")
    string.sub(userInput, 1, 1)
end

draw_dialog("game", "hello", 0.025)
draw_dialog("game", "helloaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa", 0.025)
draw_dialog("game", "helloaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa", 0.025)
draw_choice("game", "how are you?", "good", "yay", "", 2, 0.025)
if userInput == "1" then
    draw_dialog("game", "yay", 0.025)
elseif userInput == "2" then
    draw_dialog("game", "ha", 0.025)
else
    draw_dialog("game", "ok", 0.025)
end