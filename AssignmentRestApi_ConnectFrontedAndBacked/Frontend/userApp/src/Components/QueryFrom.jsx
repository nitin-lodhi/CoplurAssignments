import { useState } from "react";
import "./QueryForm.css";
import UserProfile from "./UserProfile";

const QueryFrom = () => {

    const [users, setUsers] = useState([]);
    const [id, setId] = useState("");

    
    const handleUserByID = () => {
        if (id.trim() !== "") {
            const url = `http://localhost:5219/api/UserApi/${id}`;
            fetch(url)
                .then((res) => res.json())
                .then((data) => {
                    if (Array.isArray(data)) {
                    setUsers(data);
                } else {
                    setUsers([data]);
                }
                })
                .catch((err) => {
                    alert(`User not found by the given id ${id}`);
                    console.log("Error while fetching data : ", err);
                });
        } else {
            alert("Id Is Required.");
        }
    };

    const handleAllUser = () => {
        const url = "http://localhost:5219/api/UserApi/allUsers";
        fetch(url)
            .then((res) => res.json())
            .then((data) => setUsers(data))
            .catch((err) => {
                console.log("Error while fetching data : ", err);
            });

    };

    const handleIdChange = (e) => {
        setId(e.target.value);
    };
    

   
    return (
        <> 
            { users && users.length > 0 ? 
                <div className="user-profiles">
                    {users.map((user) => (
                        <UserProfile key={user.id} user={user} />
                    ))}
                </div>
             : 
                <form>
                    <div className="container">
                        <div>
                            <input
                                type="text"
                                className="form-control"
                                id="id"
                                aria-describedby="emailHelp"
                                placeholder="Enter user's ID..."
                                value={id}
                                onChange={handleIdChange}
                            />
                        </div>
                        <button
                            type="button"
                            className="btn btn-primary"
                            onClick={handleUserByID}
                        >
                            User by ID
                        </button>
                        <button
                            type="button"
                            className="btn btn-primary"
                            onClick={handleAllUser}
                        >
                            All Users Profile
                        </button>
                    </div>
                </form>
            }
        </>
    );
};

export default QueryFrom;
