using FinalProjectCSharp2;


    class Physics : IUpdate
    {
        List<Rigidbody> _rigidbodies = new List<Rigidbody>();

        public void Add(Rigidbody rb)
        {
            _rigidbodies.Add(rb);
        }

        public void Update(float deltaTime)
        {
            foreach (var rb in _rigidbodies)
            {
                var collider = rb.Collider;

                foreach (var rb2 in _rigidbodies)
                {
                    if (rb2 == rb)
                        continue;

                    var v2 = rb2.gameobject.transform.Position;
                    var v1 = rb.gameobject.transform.Position;
                    var v3 = v2 - v1;

                    var magnitude = v3.Magnitude;
                    var radii = rb.Collider.Radius + rb2.Collider.Radius;

                    if (magnitude < radii)
                    {
                        rb.Collider.OnCollision(rb2.Collider);
                        rb2.Collider.OnCollision(rb.Collider);
                    }
                }
            }
        }

        private static Physics _instance;
        public static Physics Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Physics();

                return _instance;
            }
        }

        private Physics() { }
    }




