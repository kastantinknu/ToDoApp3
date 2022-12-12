const baseUrl = `https://localhost:7051/mytodos`;

export const loadTodos = () => {
    return fetch(baseUrl).then(res => res.json());
};

export const getTodo = (id) => {
    return fetch(`${baseUrl}/${id}`).then(res => res.json());
};

export const createTodo = (todo) => {
    return fetch(baseUrl, {
        method: "POST",
        headers: {
            "Content-Type": "application/json"
        },
        body: JSON.stringify({
            title: todo.title,
             completed: todo.completed
        }),
    }).then(res => res.json());
};

 export const updateTodo = (todo) => {
         return fetch(`${baseUrl}?id=${todo.id}`, {
         method: "PUT",
         headers: {
             "Content-Type": "application/json"
         },
         body: JSON.stringify({
             id: todo.id,
             title: todo.title,
             completed: todo.completed
         }),
     }).then(res => res.json());
 };

 export const deleteTodo = (id) => {
     return fetch(`${baseUrl}?id=${id}`, {
         method: "DELETE",
         headers: {
             'Content-type': 'application/json; charset=UTF-8' // Indicates the content 
            },     
     }).then(res => res.json()).
     then(() => {
         console.log('removed');
     })
     .then(data => console.log(data)) // Manipulate the data retrieved back, if we want to do something with it
     .catch(err => console.log(err));
 };
