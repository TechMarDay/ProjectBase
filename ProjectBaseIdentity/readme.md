**1. Authentication là gì?**
- Authentication là quá trình xác nhận danh tính của một người dùng, thiết bị hoặc ứng dụng để đảm bảo rằng họ có quyền truy cập vào một hệ thống hoặc dịch vụ cụ thể. Trong môi trường công nghệ thông tin, việc xác thực thường bao gồm sử dụng thông tin như tên người dùng và mật khẩu, mã thông báo, vân tay, hoặc các phương tiện khác để chứng minh danh tính của một cá nhân hoặc thiết bị. Điều này giúp đảm bảo rằng chỉ những người dùng được ủy quyền mới có thể truy cập vào dữ liệu và tài nguyên cần thiết.
![image](https://github.com/TechMarDay/ProjectBases/assets/71170503/35384a47-e489-401a-b4bf-8cef97877cfd)

**2. Authorization  là gì?**

- Authorization (Ủy quyền) là quá trình xác định xem một người dùng, thiết bị hoặc ứng dụng có quyền truy cập vào các tài nguyên, dịch vụ hoặc chức năng cụ thể hay không. Trong hệ thống thông tin, sau khi một cá nhân hoặc thiết bị đã được xác thực thành công (authentication), quá trình ủy quyền sẽ quyết định xem họ có quyền truy cập vào những gì và thực hiện những hành động gì.

- Ví dụ, sau khi bạn đăng nhập vào một hệ thống với thông tin đăng nhập của mình, hệ thống sẽ kiểm tra quyền hạn của bạn để xác định liệu bạn có thể xem, sửa đổi hoặc xóa dữ liệu nào, hoặc có thể thực hiện các hành động cụ thể khác như tạo bài viết mới, tải lên tệp tin, hoặc chỉnh sửa cài đặt. Quá trình này giúp bảo vệ dữ liệu và tài nguyên khỏi việc truy cập trái phép bằng cách chỉ cho phép người dùng truy cập vào những gì họ được phép dựa trên quyền hạn của họ.
![image](https://github.com/TechMarDay/ProjectBases/assets/71170503/e85d4c6b-a267-4c05-bbd7-9aaa44782d21)

**3. JWT là gì**

- JWT là viết tắt của JSON Web Token. Đây là một tiêu chuẩn mở được sử dụng để truyền thông tin một cách an toàn giữa các bên dưới dạng một đoạn văn bản dễ đọc và diễn giải, được mã hóa theo chuẩn JSON.

- JWT thường được sử dụng để xác thực và ủy quyền trên Internet. Ví dụ, khi một người dùng đăng nhập vào một ứng dụng web, máy chủ sẽ tạo ra một JWT và gửi nó cho người dùng. JWT sẽ chứa các thông tin về người dùng, như ID người dùng và các quyền truy cập của họ. Người dùng sẽ gửi lại JWT này với mỗi yêu cầu tiếp theo, và máy chủ sẽ kiểm tra xem JWT có hợp lệ không và cho phép truy cập tương ứng.

- Một trong những ưu điểm của JWT là khả năng di động, tức là nó có thể được gửi qua mạng và lưu trữ trên bất kỳ thiết bị nào mà không cần phải lưu trữ trạng thái. Điều này làm cho JWT trở thành một cách hiệu quả để xác thực và ủy quyền trong các ứng dụng phân tán và các dịch vụ web RESTful.

![image](https://github.com/TechMarDay/ProjectBases/assets/71170503/bf70484a-aa56-4067-ba64-abfaf5200e47)

**4. Single sign on là gì?**
- Single Sign-On (SSO) là một phương pháp xác thực trong công nghệ thông tin cho phép người dùng truy cập vào nhiều ứng dụng hoặc dịch vụ khác nhau mà chỉ cần đăng nhập một lần duy nhất. Thay vì phải đăng nhập lại cho mỗi ứng dụng hoặc dịch vụ riêng biệt, SSO cho phép người dùng truy cập vào nhiều hệ thống mà không cần phải nhập thông tin đăng nhập lặp đi lặp lại.
![image](https://github.com/TechMarDay/ProjectBases/assets/71170503/03fd1739-8e14-426b-97be-01c1af10ad4c)

**5. MFA là gì**
- MFA là viết tắt của "Multi-Factor Authentication" (Xác thực đa yếu tố). Đây là một phương pháp xác thực bảo mật trong công nghệ thông tin, trong đó người dùng cần phải cung cấp ít nhất hai hoặc nhiều hơn các yếu tố xác thực để chứng minh danh tính của họ trước khi được phép truy cập vào hệ thống hoặc dịch vụ.

![image](https://github.com/TechMarDay/ProjectBases/assets/71170503/131e5afe-955a-4aab-9ada-55a8027da037)

**6. Các features trong identity project base**
- Register User
- Authentication
- Reset password
- Email Confirmation
- User Lockout
- Two factor authentication
- Login with external provider (google, facebook)

### Nguồn:
- https://code-maze.com/asp-net-core-identity-series/
