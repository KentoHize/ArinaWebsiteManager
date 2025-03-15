function ChangeDateTimeToArDate(datetime) {

    var y = parseInt(datetime.substr(0, 4));
    var data = datetime.split("/");
    data[3] = data[2].split(" ")[1]; //Time
    data[2] = data[2].split(" ")[0]; //Day

    data[1] = data[1].length == 1 ? `&nbsp;${data[1]}` : data[1]; //Month
    data[2] = data[2].length == 1 ? `&nbsp;${data[2]}` : data[2];
    data[0] = "&nbsp;".repeat(3 - y.toString().length) + y; // Year
    return `${data[1]},&nbsp;${data[2]},&nbsp;Ar.${data[0]}(${y + 2017})&nbsp;&nbsp;${data[3]}`;
}

function ChangeDateToArDate(date)
{
    if (date == "-")
        return date;
    var data = date.split("/");
    return `${parseInt(data[1])},&nbsp;${parseInt(data[2])},&nbsp;Ar.${parseInt(data[0])}`;
}

function ChangeLFtoBRLabel(s) {
    
    return s.replaceAll("\n", "<br />");
}