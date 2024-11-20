fetch('/books')
    .then(response => {
        if (!response.ok) {
            throw new Error(`HTTP error! status: ${response.status}`);
        }
        return response.json();
    })
    .then(data => {
        const bookList = document.getElementById('bookList');
        data.forEach(book => {
            const li = document.createElement('li');
            li.textContent = `${book.Title} by ${book.Author} (${book.Pages} pages)`;
            bookList.appendChild(li);
        });
    })
    .catch(error => {
        console.error('There has been a problem with your fetch operation:', error);
    });