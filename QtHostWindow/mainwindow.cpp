#include "mainwindow.h"
#include "ui_mainwindow.h"
#include <QMessageBox>

MainWindow::MainWindow(QWidget *parent)
    : QMainWindow(parent)
    , ui(new Ui::MainWindow)
{
    ui->setupUi(this);
	connect(ui->actionNew_File, SIGNAL(triggered()), this, SLOT(NewFile()));
}

MainWindow::~MainWindow()
{
    delete ui;
}

void MainWindow::NewFile()
{
	QMessageBox::about(this, "New File", "action executed");
}