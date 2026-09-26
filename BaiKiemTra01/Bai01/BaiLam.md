Câu 1: Phân biệt Value Types và Reference Types về cơ chế lưu trữ vùng nhớ
- Value Types (kiểu giá trị) là kiểu dữ liệu mà biến lưu trực tiếp giá trị của nó. Ví dụ: int, double, bool, struct. Khi gán một biến kiểu giá trị cho biến khác, giá trị được sao chép sang biến mới.
- Reference Types (kiểu tham chiếu) là kiểu dữ liệu mà biến lưu tham chiếu (địa chỉ/tham chiếu) đến đối tượng được lưu trong vùng nhớ Heap. Ví dụ: class, object, string, array. Khi gán một biến kiểu tham chiếu cho biến khác, hai biến có thể cùng tham chiếu đến một đối tượng.
- Về vùng nhớ:
+ Stack: thường chứa biến cục bộ và dữ liệu giá trị trực tiếp của Value Type. 
+ Heap: thường chứa các đối tượng được tạo từ Reference Type bằng new. 
+ Tuy nhiên, không nên hiểu tuyệt đối rằng Value Type luôn nằm trên Stack và Reference Type luôn nằm trên Heap; vị trí thực tế phụ thuộc vào cách biến được sử dụng và cách CLR quản lý bộ nhớ.

Câu 2: init khác gì set thông thường?
- init và set đều cho phép gán giá trị cho Property, nhưng khác nhau ở thời điểm được phép gán.
+ set: Có thể gán hoặc thay đổi giá trị bất cứ lúc nào sau khi đối tượng được tạo. 
+ init: Chỉ được phép gán giá trị khi khởi tạo đối tượng, sau đó không thể thay đổi.

Câu 3: Phân biệt virtual và override trong đa hình
- virtual được khai báo ở lớp cha, cho phép phương thức đó được lớp con ghi đè (override).
- override được khai báo ở lớp con, dùng để cung cấp cách triển khai mới cho phương thức virtual của lớp cha.

Câu 4: Tại sao static không thể truy xuất thông qua Object Instance?
- Thành phần được khai báo static thuộc về lớp (Class), không thuộc về từng đối tượng (Object Instance). Vì vậy, nó không cần tạo đối tượng bằng new để sử dụng và được dùng chung cho tất cả các đối tượng của lớp.
- Do đó, thành phần static phải được truy xuất thông qua tên lớp, không phải thông qua đối tượng.