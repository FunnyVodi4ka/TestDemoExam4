   M S B A M L   `   `   `  ����H  DTestDemoExam4, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:TestDemoExam4.AuthorizationTestDemoExam4.Authorization  5   	   /    )TestDemoExam4.Authorization.WindowCaptcha   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ;local)clr-namespace:TestDemoExam4.Authorization     5   	   -   5          � Title$  Captcha��5   	   $	��450��6   $	��800��6&    � Icon$( "/Resources/AppImages/Logo-mini.png��62    � WindowStyle$
 None=�6\    � 
ResizeMode$ NoResize=�6o    � SizeToContent$ WidthAndHeight=�6�    � WindowStartupLocation$ CenterScreen=�6�    � ShowInTaskbar .  .��5	      �  � ColumnDefinitions 5
   
   �� 5       � RowDefinitions 5   
   �� 5      .+�5   
   ��  
  spMain#��[  6   	 �� Orientation$	 Vertical=�65   .+�5      �� -   5        
 ��Name$
 
tblCaptcha��5      $��captcha��6,     tblMain#��[ 6;    �� TextAlignment$ Center=�6\   $
��auto��6s   $��Segoe UI Symbol)�6�   $��Strikethrough{�6�    J� RenderTransformOrigin$ 0.5,0.5&�6�   z�5      V� 5      .~�5      �� �� 5      �� 5       �� Angle$ -4.399Q�6*   T� 5      5      5      �� 5      -   5         ��Name$ 	tbCaptcha��5       
 tbMain#��[ 6)   �� 5      -   5         ��Name$ 
btnCaptcha��5      $
��SEND��6)     btnMain#��[ 68   6Y   5      5      5       