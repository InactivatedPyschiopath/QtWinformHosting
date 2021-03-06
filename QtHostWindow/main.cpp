#include "mainwindow.h"

#include <QApplication>
#include <Windows.h>
#include <QWinHost>

// import from winform.dll
extern "C" __declspec(dllimport) HWND CreateForm(HWND);

int main(int argc, char *argv[])
{
    QApplication a(argc, argv);
    MainWindow w;

	// create winform
	HWND form = CreateForm((HWND)w.winId());

	// apply child style to form to avoid focus lose
	LONG_PTR style = GetWindowLongPtr(form, GWL_STYLE);
	SetWindowLongPtr(form, GWL_STYLE, style | WS_CHILD);

	// host winform
	QWinHost* host = new QWinHost;
	host->setWindow(form);
	w.setCentralWidget(host);

	// Show 
	w.show();
    return a.exec();
}