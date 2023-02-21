'use strict';
var returnResult;

(function () {

    Office.onReady(function () {
        // Office is ready.
        $(document).ready(function () {
            // The document is ready.
            // Use this to check whether the API is supported in the Word client.
            console.log("In OnReady");
            if (Office.context.requirements.isSetSupported('WordApi', '1.1')) {
                // Do something that is only available via the new APIs.
                $('#rewrite').click(rewrite);
                $('#btnIteas').click(btnIdeas);
                $('#supportedVersion').html('This code is using Word 2016 or later.');
            }
            else {
                // Just letting you know that this code will not work with your version of Word.
                $('#supportedVersion').html('This code requires Word 2016 or later.');
            }
        });
    });

    async function insertEmersonQuoteAtSelection() {
        await Word.run(async (context) => {

            // Create a proxy object for the document.
            const thisDocument = context.document;

            // Queue a command to get the current selection.
            // Create a proxy range object for the selection.
            const range = thisDocument.getSelection();

            // Queue a command to replace the selected text.
            range.insertText('"Hitch your wagon to a star."\n', Word.InsertLocation.replace);

            // Synchronize the document state by executing the queued commands,
            // and return a promise to indicate task completion.
            await context.sync();
            console.log('Added a quote from Ralph Waldo Emerson.');
        })
            .catch(function (error) {
                console.log('Error: ' + JSON.stringify(error));
                if (error instanceof OfficeExtension.Error) {
                    console.log('Debug info: ' + JSON.stringify(error.debugInfo));
                }
            });
    }

    async function insertChekhovQuoteAtTheBeginning() {
        await Word.run(async (context) => {

            // Create a proxy object for the document body.
            const body = context.document.body;

            // Queue a command to insert text at the start of the document body.
            body.insertText('"Knowledge is of no value unless you put it into practice."\n', Word.InsertLocation.start);

            // Synchronize the document state by executing the queued commands,
            // and return a promise to indicate task completion.
            await context.sync();
            console.log('Added a quote from Anton Chekhov.');
        })
            .catch(function (error) {
                console.log('Error: ' + JSON.stringify(error));
                if (error instanceof OfficeExtension.Error) {
                    console.log('Debug info: ' + JSON.stringify(error.debugInfo));
                }
            });
    }

    async function btnIdeas() {

        await Word.run(async (context) => {

            //callGPT3(document.getElementById('txtIdeas').value);
            returnResult = "";
            // Create a proxy object for the document body.
            const body = context.document.body;

            // Queue a command to insert text at the end of the document body.
            //body.insertText('"To know the road ahead, ask those coming back."\n', Word.InsertLocation.end);

            //body.insertText(returnResult, Word.InsertLocation.end);

            callGPT3(document.getElementById('txtIdeas').value).then(
                function (value) {
                    body.insertText(returnResult, Word.InsertLocation.end);
                    context.sync();
                },
                function (error) { document.getElementById('message').innerText = "error"; }
            );

            // Synchronize the document state by executing the queued commands,
            // and return a promise to indicate task completion.
            //await context.sync();

                 })
            .catch(function (error) {
                console.log('Error: ' + JSON.stringify(error));
                if (error instanceof OfficeExtension.Error) {
                    console.log('Debug info: ' + JSON.stringify(error.debugInfo));
                }
            });
    }
    /* 
     * First Rewrite button is pressed 
     * This get the prompt i.e. "Rewrite this " + selected tex
     * Then call the OpenAI and pass the prompt 
     * 

    */

    function createMovies(movie) {
        return new Promise((resolve, reject) => {
            setTimeout(() => {
                movies.push(movie);

                const error = false;

                if (!error) {
                    resolve();
                }
                else {
                    reject('Error: Something went wrong!')
                }
            }, 2000);
        })
    }

    async function rewrite() {
        //return new Promise((resolve, reject) => {

        //})

        console.log("in rewrite");
        var prompt = "Rewrite the following \n";
        var result;
        Office.context.document.getSelectedDataAsync(Office.CoercionType.Text, function (asyncResult) {
            if (asyncResult.status == Office.AsyncResultStatus.Failed) {
                write('Action failed. Error: ' + asyncResult.error.message);
            }
            else {
                //TODO: add a check for empty selected string
                prompt += asyncResult.value;

                //callGPT3(prompt).then(result => {console.log(result)});
                //result = await callGPT3(prompt);
                //document.getElementById('message').innerText = result;
                callGPT3(prompt).then(
                    function (value) { document.getElementById('message').innerText = returnResult; },
                    function (error) { document.getElementById('message').innerText = "error"; }
                );
                //document.getElementById('message').innerText = returnResult;


               
            }
        });
    }

    // Function that writes to a div with id='message' on the page.
    async function write(message) {
        console.log("in write");
        document.getElementById('message').innerText = message;
    }

    async function callGPT3(prompt) {
        let myPromise = new Promise(function (resolve) {

            console.log("in GPT3");
            const params = {
                "model": "text-davinci-003",
                "prompt": prompt,
                "max_tokens": 160,
                "temperature": 0.7,
                "frequency_penalty": 0.5
            };
            var xhr = new XMLHttpRequest();
            xhr.open("POST", "https://api.openai.com/v1/completions", true);
            xhr.setRequestHeader("Content-Type", "application/json");
            xhr.setRequestHeader("Authorization", "Bearer " + "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");
            xhr.send(JSON.stringify(params));
            xhr.onreadystatechange = function () {
                if (xhr.readyState === 4 && xhr.status === 200) {
                    var json = JSON.parse(xhr.responseText);
                    console.log(json.choices[0].text);
                    //write(json.choices[0].text);
                    returnResult = json.choices[0].text;
                    resolve("done!");
                }
            };
            
        });
        await myPromise

    }

    // PROMISE exmaple
    //async function callGPT3(prompt) {
    //    let promise = new Promise(function (resolve, reject) {
    //        returnResult = "";

    //        console.log("in GPT3");
    //        var retrunString = "";
    //        const error = false;
    //        const params = {
    //            "model": "text-davinci-003",
    //            "prompt": prompt,
    //            "max_tokens": 160,
    //            "temperature": 0.7,
    //            "frequency_penalty": 0.5
    //        };
    //        var xhr = new XMLHttpRequest();
    //        xhr.open("POST", "https://api.openai.com/v1/completions", true);
    //        xhr.setRequestHeader("Content-Type", "application/json");
    //        xhr.setRequestHeader("Authorization", "Bearer " + "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");
    //        xhr.send(JSON.stringify(params));
    //        xhr.onreadystatechange = function ()
    //        {
    //            if (xhr.readyState === 4 && xhr.status === 200) {
    //                var json = JSON.parse(xhr.responseText);
    //                console.log(json.choices[0].text);
    //                //write(json.choices[0].text);
    //                returnResult = json.choices[0].text;
    //                resolve(returnResult)
    //            } else { reject(returnResult = "error") }
    //        };

    //    });

 //   }

    // --------- Working function ------------
    //function callGPT3(prompt) {
    //    console.log("in GPT3");
    //    const params = {
    //        "model": "text-davinci-003",
    //        "prompt": prompt,
    //        "max_tokens": 160,
    //        "temperature": 0.7,
    //        "frequency_penalty": 0.5
    //    };
    //    var xhr = new XMLHttpRequest();
    //    xhr.open("POST", "https://api.openai.com/v1/completions", true);
    //    xhr.setRequestHeader("Content-Type", "application/json");
    //    xhr.setRequestHeader("Authorization", "Bearer " + "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");
    //    xhr.send(JSON.stringify(params));
    //    xhr.onreadystatechange = function () {
    //        if (xhr.readyState === 4 && xhr.status === 200) {
    //            var json = JSON.parse(xhr.responseText);
    //            console.log(json.choices[0].text);
    //            //write(json.choices[0].text);
    //            //return json.choices[0].text;
    //            return new Promise(result => {
    //                result(json.choices[0].text);
    //            }
    //            )
    //        }
    //    };
    //}

    // Function to fade the image 
    function fadeIn(el) {
        el.style.opacity = 0;
        var tick = function () {
            el.style.opacity = +el.style.opacity + 0.05;
            if (+el.style.opacity < 1) {
                var x = (window.requestAnimationFrame && requestAnimationFrame(tick)) || setTimeout(tick, 16)
            }
        };
        tick();
    }

    //Function to generate ideas
    //async function btnIdeas() {
    //    console.log("btnideas");
        
    //}
 
})();
