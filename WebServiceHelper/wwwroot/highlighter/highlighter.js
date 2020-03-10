debugger;
$("#target").click(function () {
    var data = $('#Response').val();
    var lines = $('#Response').val().split('\n');
    var lg = lines.length;
    var regex = /"[^"\\\n]*"(?=\s*:)/;
    var tempProperties = [];
    for (var i = 1; i < lg - 1; i++) {
        tempProperties.push(regex.exec(lines[i])[0]);
    }
    var templength = tempProperties.length;
    //for (var k = 0; templength > k; k++) {
    //    alert(tempProperties[k]);
    //}
});

