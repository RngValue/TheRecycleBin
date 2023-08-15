items = {}
width = 41

function sleep(n)
    local t = os.clock()
    while os.clock() - t <= n do
      -- nothing
    end
end  

function show_items()
    io.write("#########################################\n")
    io.write("#\t", type(items[1]), "\t", type(items[2]), "\t", type(items[3]), "\t", type(items[4]), "\t#\n")
    io.write("#########################################\n")
end



function draw_dialog(text, delay)
    os.execute("clear")
    show_items()
    for i = 1, #text do
        if i == width+1 then
            io.write("\n")
        end
        io.write(string.sub(text, i, i))
        sleep(delay)
        if i == width*2 - 3 then break end
        --if i ~= #dialogtext then os.execute("clear") end
    end
    if #text <= width then
        io.write("\n")
        for j = 1, width - 2 do io.write(" ") end
        io.write("<>")
    else
        for j = 1, width - (#text - width) - 2 do io.write(" ") end
        io.write("<>")
    end
    io.read()
end

draw_dialog("ahojaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa", 0.025)