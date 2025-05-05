function isIOSDevice(nv) {
    return [
        'iPad Simulator',
        'iPhone Simulator',
        'iPod Simulator',
        'iPad',
        'iPhone',
        'iPod'
    ].includes(nv.platform)
        || (nv.userAgent.includes("Mac") && "ontouchend" in document);
}

function roundToNDecimal(num, n = 0) {
    return +(Math.round(num + `e+${n}`) + `e-${n}`);
}

function ShowArDateTimeFromDateObject(date) {
    return `${date.getUTCMonth() + 1},&nbsp;${date.getUTCDate()},&nbsp;Ar.&nbsp;${date.getUTCFullYear() - 2017}&nbsp;
    ${date.getUTCHours()}:${date.getUTCMinutes().toString().padStart(2, '0')}:${date.getUTCSeconds().toString().padStart(2, '0')}`;
}

function ChangeDateTimeToArDateTime(datetime) {    
    return `${parseInt(datetime.substr(10, 2))},&nbsp;${parseInt(datetime.substr(13, 2))},&nbsp;Ar.&nbsp;${parseInt(datetime.substr(3, 6))}&nbsp;${parseInt(datetime.substr(16, 2))}${ datetime.substr(18, 7)}`;
}

function ChangeDateTimeToArDate(datetime) {
    return ChangeDateToArDate(datetime.substr(0, 15));
}

function ChangeDateToArDate(date)
{
    if (date == "-")
        return date;
    return `${parseInt(date.substr(10, 2))},&nbsp;${parseInt(date.substr(13, 2))},&nbsp;Ar.&nbsp;${parseInt(date.substr(3, 6))}`;
}

function ChangeDateTimeToCEDateTime(datetime) {
    return `${parseInt(datetime.substr(3, 6)) + 2017}/${parseInt(datetime.substr(10, 2))}/${parseInt(datetime.substr(13, 2))} ${parseInt(datetime.substr(16, 2))}${datetime.substr(18, 7)}`;
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
    //var width = screen.width;
    var width = window.innerWidth;
    if (width  < 500) {
        window_size = 'mi';
        window_size_width = 330;
    }
    else if (width < 800) {
        window_size = "s";
        window_size_width = 450;
    }
    else if (width < 1200) {
        window_size = "m";
        window_size_width = 750;
    }
    else {
        window_size = "l";
        window_size_width = 1100;
    }
    if (max) {
        window_size = "l";
        window_size_width = 1100;
    }
}

function Initialize() {
    GetWindowSize();
}