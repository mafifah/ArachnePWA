////function myFaktur() {
////    var divContents = document.getElementById("myFaktur").innerHTML;
////    var a = window.open( 'height=500, width=500');
////    //a.document.write('<html>');
////    //a.document.write('<style type = "text/css">');
////    //a.document.write('</style>');
////    //a.document.write('</head><body >');
////    //a.document.write('<body > <br>');
////    //a.document.write(divContents);
////    //a.document.write('</body></html>');
////    a.document.close();
////    a.focus();
////    self.print();
////}


function myFaktur() {
    var contents = document.getElementById("myFaktur").innerHTML;
    var frame1 = document.createElement('iframe');
    frame1.name = "frame1";
    frame1.style.position = "absolute";
    frame1.style.top = "-1000000px";
    document.body.appendChild(frame1);
    var frameDoc = frame1.contentWindow ? frame1.contentWindow : frame1.contentDocument.document ? frame1.contentDocument.document : frame1.contentDocument;
    frameDoc.document.open();
    frameDoc.document.write('<html><head><title>DIV Contents</title>');
    frameDoc.document.write('</head><body>');
    frameDoc.document.write(contents);
    frameDoc.document.write('</body></html>');
    frameDoc.document.close();
    setTimeout(function () {
        window.frames["frame1"].focus();
        window.frames["frame1"].print();
        document.body.removeChild(frame1);
    }, 500);
    return false;
}

