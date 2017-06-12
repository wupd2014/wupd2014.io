jsp =java+html

编译器指令

--源码级导入 静态导入
<% inlcude import file="a.jsp" %>

--动态导入
<% jsp:include page="" >
  <jsp:param name="a" value="" />
<jsp:include>

--表达式

<%= %> //system.out.print();

内置对象

request
pageContext 上下文对象
application 


--请求转发

<jsp:forward>

base