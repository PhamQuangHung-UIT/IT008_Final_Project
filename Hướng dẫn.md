# Một số lưu ý về làm đồ án

- Đặt tên biến, hàm và file rõ ràng. Không đặt tên biến chỉ bằng 1 kí tự (trừ vòng lặp for). Hạn chế đặt tên bằng số (form1, form2, form3,...), thay vào đó nên đặt tên theo chức năng của nó (form_HoaDon, FormMain, ...)
- Gom nhóm các hàm có liên quan với nhau và đặt chúng trong cặp tiền chỉ thị ``#region Tên của region ... #endregion``
- Nếu cần đổi tên biến, hàm, lớp,... sử dụng Rename (Ctrl + R 2 lần). Visual Studio sẽ tự động đổi tên tất cả hiện diện của chúng một cách an toàn
- Các tệp tài nguyên sẽ thêm trong file Resources.recx trước. Nếu muốn sử dụng chúng chỉ cần gọi Properties.Resources.TenTaiNguyen
- Khi Commit, không thêm thư mục ".vs" vào bệ. Đây là thư mục do Visual Studio tự sinh ra trong quá trình làm việc với Project.

# Hướng dẫn cách edit nội dung và cập nhật lên Github
**Tạo bản sao cho repos**

Nếu sử dụng Visual Studio, ngay khi mở ứng dụng, trong phần Get Started, chọn "Clone a repository". Ở phần "Repository location", nhập đường dẫn trang Github của nhóm (Copy cho nhanh): 
    https://github.com/PhamQuangHung-UIT/IT008_Final_Project 
    
Sau đó chọn thư mục dùng để chứa bản sao của repos (thư mục mình chọn phải là thư mục rỗng, chỉ chứa đúng một repos bản sao)
<img width="960" alt="2022-10-25 (2)" src="https://user-images.githubusercontent.com/113542311/197781462-3df9c89d-4f1e-495f-8f3e-60170e7ee513.png">

Lưu ý chỉ áp dụng cho lần làm việc đầu tiên, lần sau muốn vào lại cứ chọn project mình đã nhân bản trước ở phần Recent file ở giao diện chính và ghim.
    ![image](https://user-images.githubusercontent.com/113542311/197779074-9cae1404-4cb3-444e-a1cb-b32d9d1b03fe.png)

Cũng tương tự nếu sử dụng Github Desktop, chọn File/Clone repository và làm tương tự như trên
<img width="459" alt="2022-10-25 (3)" src="https://user-images.githubusercontent.com/113542311/197783394-1088e9a8-882a-43ce-87ca-7b13314dbf8d.png">

    
**Đẩy nội dung lên github**
  
Ở góc dưới bên trái, chọn tab "Git Changes". Đây sẽ là nơi mình thực hiện việc đẩy file và thư mục lên web Github, cũng như lấy dữ liệu
<img width="960" alt="2022-10-25" src="https://user-images.githubusercontent.com/113542311/197778773-df7494d5-0057-4b77-a005-03d89f3a5f3b.png">

Giả sử mình cần đẩy file có tên "Demo.txt" lên Github. Để làm được việc này, cạnh file "Demo.txt" nhấn dấu cộng để đưa file vào bệ đẩy (Stage)
<img width="620" alt="2022-10-25 (4)" src="https://user-images.githubusercontent.com/113542311/197787584-a41d33b0-eb86-49cd-b81e-8cc3abc43f8c.png">

Bạn sẽ thấy file mình chuẩn bị đẩy ở phần "Stage Changes". Nhập thông tin tóm tắt lí do, nội dung file mình đẩy rồi chọn "Commit Staged"
<img width="600" alt="2022-10-25 (10)" src="https://user-images.githubusercontent.com/113542311/197792413-dc033079-0d89-433d-8045-aae37454ec77.png">

Có thể kiểm tra lại trên Github của nhóm để thấy phần dữ liệu mà mình vừa đẩy
<img width="960" alt="2022-10-25 (5)" src="https://user-images.githubusercontent.com/113542311/197793343-3d98ef63-462d-4c32-806d-76ee4e5ea1bf.png">

**Xóa file hoặc hoàn tác dữ liệu mình đẩy**

Giả sử bạn vừa gửi nhầm file lên Github. Nếu chỉ đơn giản là xóa file, lên trang Github của nhóm, nhấp vào file mình xóa và chọn biểu tượng xóa ở góc phải
![image](https://user-images.githubusercontent.com/113542311/197796676-2cd78ba1-aefa-4954-a5f2-cd65fdc9ca7c.png)

Trong trường hợp file (hoặc thư mục) không thể xóa được, cách duy nhất là đưa repos của mình về trạng thái trước khi mình "Commit" cũng như đồng bộ quá trình đó trên Github. Để làm được việc này, trở về Visual Studio, chọn Git/View Branch History để xem lịch sử những đợt mình "Commit".
<img width="960" alt="2022-10-25 (6)" src="https://user-images.githubusercontent.com/113542311/197798050-6b15b04e-7375-4708-958c-9a1079e50140.png">

Nhấp chuột phải vào đợt "Commit" mình muốn thu hồi và chọn "Revert".
<img width="960" alt="2022-10-25 (7)" src="https://user-images.githubusercontent.com/113542311/197798545-04853343-07b0-43ad-ab9c-bf27a2eb7dd5.png">

Nhấp vào biểu tượng "Sync" để đồng bộ quá trình thu hồi trên Repos cục bộ với Repos trên Github
<img width="600" alt="2022-10-25 (8)" src="https://user-images.githubusercontent.com/113542311/197799698-0fd10049-5678-4374-b0d9-3a1ec3d7ca91.png">

Bạn sẽ thấy thông báo thu hồi hiển thị trên Github nhóm
<img width="800" alt="2022-10-25 (12)" src="https://user-images.githubusercontent.com/113542311/197800781-9105dcb2-69e2-4562-81a2-85e3922894e7.png">

# Sử dụng Git

Một cách khác để làm việc với repos đó là sử dụng Git. Các repos trên Github về bản chất là các file Git. Có thể sử dụng công cụ làm việc với Git tích hợp sẵn trong Visual Studio thông qua màn hình Terminal (View > Terminal hoặc Ctrl + ` ). Các lệnh Git luôn bắt đầu bằng từ "git".

Xem tất cả các lệnh Git [tại đây](https://git-scm.com/docs)

**Một số lệnh Git thông dụng**

Cập nhật (fetch) toàn bộ nhánh có trên Github (gọi là remote branch):
````
    git fetch -p
````
Xóa một nhánh cục bộ (local branch):
````
    git branch -d <Tên nhánh>
````
hoặc
````
    git branch --delete <Tên nhánh>
````
Xóa một nhánh cục bộ bắt buộc:
````
    git branch -D <Tên nhánh>
````
hoặc
````
    git branch --delete --force <Tên nhánh>
````
**Chú ý: Không xóa nhánh main vì đây là nhánh làm việc chính của nhóm**
