# vb.net
社員管理システム

# ログイン
ログインメールアドレスとパスワードはDBで設けられた管理者データと一致するかどうかをチェック
# メイン
①．開いた時に,dataGridViewですべてのDBのデータを表示します。画像も表示できるようにしました。
②．検索欄で複数の入力から、検索結果を表示できます。
③．編集画面に遷移するには、編集したいデータのIDをTextBoxに入力して、編集ボタンをクリックして、編集画面に遷移します。
④．削除機能には、同じくIDを入力して、指定したIDによってデータを削除します。
⑤．新規登録ボタンをクリックすると、新規登録画面に遷移します。
⑥．ログアウト：クリックすると、メイン画面を閉じます。
# 新規登録
①．元々DBに存在したデータを各TextBoxに表示できます。
②．写真も表示できます。
③．TextBoxの入力をDBに更新します。
④．必須項目をチェックします。
# 編集
①．画像表示できます。
②．入力したデータをDBに追加します。
③．必須項目を設定しました。

# DBの接続
"employee.mdf"ファイルをvisual studioでインポートすることで、直接に接続できます。
