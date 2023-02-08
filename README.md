# IT008_Final_Project
Đồ án cuối kỳ môn Lập trình trực quan (Visual Programming)
# Về đồ án
Đồ án chỉ chạy được trên môi trường `C# .NET 7.0` (lí do vì sao không dùng .NET Framework thì là do sơ suất của 1 thành viên trong nhóm lúc khởi tạo và làm trước đồ án chọn nhầm loại project). Theo như tài liệu chính thức của Microsoft, yêu cầu tối thiểu để chạy chương trình .NET 7.0 bằng Visual Studio là `Visual Studio 2022 bản 17.4` trở lên. Chi tiết [tại đây](https://learn.microsoft.com/en-us/dotnet/core/install/windows?tabs=net70)

Đồ án có sử dụng hệ quản trị CSDL Microsoft SQL Server với tên server mặc định là: `<Tên thiết bị>\SQLEXPRESS`. Có thể sửa tên server trong biến *connectionString* và biến *connection* trong hàm sự kiện *FMain_Load* ở file *FMain.cs*

Database mà chương trình sử dụng là `DoAn_lttq` và chương trình sử dụng dữ liệu của file *DoAn_lttq_CreateScript.sql* để gửi lệnh khởi tạo database đến server. Quá trình khỏi tạo chỉ chạy khi chương trình không tìm thấy database nào có cùng tên `DoAn_lttq`

Để đăng nhập vào chương trình thì cần phải đăng ký tài khoản mới. Tài khoản đó mặc định sẽ có quyền Quản trị viên, những tài khoản sau muốn vào sử dụng chương trình cần phải được Quản trị viên phê duyệt. Sau khi phê duyệt mới có thể đăng nhập vào chương trình
