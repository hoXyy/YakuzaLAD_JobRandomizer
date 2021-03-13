const express = require('express');
const app = express();
const morgan = require('morgan');
var path = require('path');

app.use(morgan(':method :url :status :res[content-length] - :response-time ms'));
app.use(express.static(path.join(__dirname + "/assets")));


app.get('/', function(req, res) {
    res.sendFile(path.join(__dirname + '/assets/index.html'));
});

app.listen(3000, () => {
    console.log('Server running...');
});