const UserProfile = ({ user }) => {
    return (
        <div className="container">
            <div className="card shadow-sm" style={{ maxWidth: 540, margin: '0 auto' }}>
                <div className="row g-0">
                    <div className="col-md-4 p-3 text-center">
                        <img src={`https://randomuser.me/api/portraits/men/${user.id}.jpg`} className="rounded-circle img-thumbnail" alt="Profile Picture" />
                        <div className="mt-2">
                            <span className="badge bg-success">Online</span>
                        </div>
                    </div>
                    <div className="col-md-8">
                        <div className="card-body">
                            <h5 className="card-title d-flex justify-content-between align-items-center">
                                {user.name}
                                <button className="btn btn-sm btn-outline-primary">
                                    <i className="fas fa-edit" /> Edit
                                </button>
                            </h5>
                            <p className="card-text text-muted">
                                <i className="fas fa-briefcase" /> {user.role}
                            </p>
                            <p className="card-text">
                                <small className="text-muted">
                                    <i className="fas fa-map-marker-alt" /> {user.city}
                                </small>
                            </p>
                            <div className="border-top pt-2">
                                <div className="row text-center">
                                    <div className="col">
                                        <h6>Projects</h6>
                                        <strong>{user.projects}</strong>
                                    </div>
                                    <div className="col border-start">
                                        <h6>Following</h6>
                                        <strong>{user.following}</strong>
                                    </div>
                                    <div className="col border-start">
                                        <h6>Followers</h6>
                                        <strong>{user.followers}</strong>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
                <div className="card-footer bg-white">
                    <div className="d-flex justify-content-around">
                        <button className="btn btn-link text-decoration-none">
                            <i className="fas fa-user-plus" /> Follow
                        </button>
                        <button className="btn btn-link text-decoration-none">
                            <i className="fas fa-envelope" /> Message
                        </button>
                        <button className="btn btn-link text-decoration-none">
                            <i className="fas fa-share" /> Share
                        </button>
                    </div>
                </div>
            </div>
        </div>

    )
}

export default UserProfile
