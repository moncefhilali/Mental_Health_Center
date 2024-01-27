export interface Treatment {
  topic: string;
  body: string;
  createdAt: string;
  doctor: {
    firstname: string;
    lastname: string;
    specialty: string;
    image: {
      path: string;
    };
  };
  image: {
    path: string;
  };
}
