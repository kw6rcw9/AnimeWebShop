   M S B A M L   `   `   `  ����G  CAnimeWebShop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:AnimeWebShopAnimeWebShop  5   	   9!clr-namespace:AnimeWebShop.ModelsAnimeWebShop.Models  5   	       AnimeWebShop.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   _ [MaterialDesignThemes.Wpf, Version=4.9.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   &localclr-namespace:AnimeWebShop  5   	   .Models!clr-namespace:AnimeWebShop.Models  5   	     � 
ResizeMode$  NoResize=�5
   	   ���#16161c � Icon$ /Images/icon.png��5   	    � Title$ MainApp��5   	   $	��450��6   $	��800��6&   .��5      �  � ColumnDefinitions 5   
   �� 5      $	��280 �6   �� 5      .+�5   
   �� $��1��6   .+�5      �� $%��Интернет магазин��6   
�������$��Center=�6B   $��30q�6_   $��28(�6k      MaterialDesignLabel#��[  6y   $��Medium"�6�   �� 5      $	��297��6   $	��482��6(   .��5      �� -   5         ��Name$ ItemsListBox��5   4   
������ $��Disabled=�6J   ��5      �� 5       �� 
TargetType" ��6     �� BasedOn# [B��5       �� Triggers 5      P� 5   "    P� Property �@J�IsKeyboardFocusWithin	 P� Value	 . . �5   &   �� 
 �� Property
 �@��
IsSelected �� Value . 6C   5   #   5!      ��5#      �� 5$   "   .R�5%   &   ��  �� Orientation$ Vertical=�61   .+�5&   *   ��  ��Name$ 	ItemImage��6o   $	��300��60   $��
0,10,10,10q�6>   $��Center=�6R   ��6�   �� *ImageSource+�� 5'   *    ��Name$ ItemName��6E   ���#E85F88#��[  6W   $��20(�6�   ��6�   �� *Name+�� 5(   *    ��Name$ ItemDesc��6G   
�������$��16(�6Y   $
��Wrap=�6�   ��6g   �� *Description+6�   �� 5)   *   $ 
Horizontal=�65   .+�5*   .   �� ���#5FE8DA$��18(�6I   $��	Цена:��6W   $��Italic$�6g   �� 5+   .   $ 	ItemPrice��6G   
�������$��16(�6Z   ��6h   �� *Price+�� 5,   .   
�������$��16(�6H   $��$��6V   5-   +   �� 5/   *    ��Name$ AddToCartButton��63   -   5        $��В корзину��5/   L   $	��110��6`   $
��Left=�6l   6�   50   '   51   #   54      55      58      �� 59   
   $��0��6   $ Vertical=�6%   .+�5:      �� $��/Images/cart.png��6   $	��150��6.   $��40q�6;   �� 5;      -   5        $ CartInfoLabel��5;      $5��/Ваша корзина сейчас пуста��6+   $��50, 0, 0, 0q�6O   
�������$��13(�6w   $
��Bold"�6�   �� 5<      -   5        $ CartAmountLabel��5<      $�� ��6-   $��50, 0, 0, 0q�68   
�������$��13(�6`   $
��Bold"�6n   �� 5=      -   5        $ CartPriceLabel��5=      $�� ��6,   $��50, 0, 0, 0q�67   
�������$��13(�6_   $
��Bold"�6m   �� 5>      -   5        $��Оплатить��5>      $	��146��6(   $��50q�64      MaterialDesignOutlinedButton#��[ 6@   6v   5@      5A      5B      