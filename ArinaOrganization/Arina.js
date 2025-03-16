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

function ApplyLeadingSpaceAndBRLabel(s) {
    var ss = s.split(`\n`);
    var result = ``;
    for (let i = 0; i < ss.length; i++)
        if (i != ss.length - 1)
            result += `&emsp;&emsp;${ss[i]}<br />`;
        else
            result += `&emsp;&emsp;${ss[i]}`;
    return result;
}

function GetTodayArDate() {
    var today = new Date(Date.now());    
    return `${String(today.getFullYear() - 2017).padStart(4, `0`)}-${String(today.getMonth() + 1).padStart(2, `0`)}-${String(today.getDate()).padStart(2, `0`)}`;
}

function GetURLParameter() {
    if (!location.search.includes(`?`))
        return null;
    var ps = location.search.split(`?`)[1].split(`&`);
    var result = {};
    for (let i = 0; i < ps.length; i++) {
        let a = ps[i].split(`=`);
        result[decodeURI(a[0])] = decodeURI(a[1]);
    }
    return result;
}

var window_size, window_size_width;
function GetWindowSize(max = false) {

    //if (window.innerWidth < 600) {
    //    window_size = 'mi';
    //    window_size_width = 400;
    //}
    if (window.innerWidth < 800) {
        window_size = "s";
        window_size_width = 500;
    }
    else if (window.innerWidth < 1300) {
        window_size = "m";
        window_size_width = 750;
    }
    else {
        window_size = "l";
        window_size_width = 1250;
    }
    if (max) {
        window_size = "l";
        window_size_width = 1250;
    }
}

function Initialize() {
    GetWindowSize();
}