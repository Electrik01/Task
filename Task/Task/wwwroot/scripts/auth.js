
async function getTokenAsync() {

    const formData = new FormData();
    formData.append("grant_type", "password");
    formData.append("Login", document.getElementById("login").value);
    formData.append("Password", document.getElementById("password").value);
    formData.append("Name", "Name");

    const response = await fetch("/token", {
        method: "POST",
        headers: { "Accept": "application/json" },
        body: formData
    });
    const data = await response.json();

    if (response.ok === true) {
        sessionStorage.setItem(tokenKey, data.access_token);
        window.location.replace('users.html');

    }
    else {
        const errorData = data;
        if (errorData) {
            let err = document.getElementById("errors");
            while (err.firstChild) {
                err.removeChild(err.firstChild);
            }

            if (errorData["Password"]) {

                addError(errorData["Password"]);
            }
            if (errorData["Login"]) {
                addError(errorData["Login"]);
            }

        }

        document.getElementById("errors").style.display = "block";
    }
}